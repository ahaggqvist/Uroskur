using System.Collections.Immutable;
using System.Text;
using Microsoft.Extensions.Caching.Distributed;
using Uroskur.DataAccess.Repositories;
using Uroskur.Model;
using Uroskur.Shared;
using Uroskur.Shared.Models;

#pragma warning disable CS8629

namespace Uroskur.WebApp.Services;

public class StravaService : IStravaService
{
    private const int CacheHours = 1;
    private const int MaxDistances = 10;
    private static readonly Encoding DefaultEncoding = new UTF8Encoding(false);
    private readonly IDistributedCache _cache;
    private readonly ILogger<StravaService> _logger;
    private readonly ISettingRespository _settingRespository;
    private readonly IStravaClient _stravaClient;
    private readonly IStravaUserRepository _stravaUserRepository;

    public StravaService(ILogger<StravaService> logger, IStravaClient stravaClient, IStravaUserRepository repository,
        IDistributedCache cache, ISettingRespository settingRespository)
    {
        _logger = logger;
        _stravaClient = stravaClient;
        _stravaUserRepository = repository;
        _cache = cache;
        _settingRespository = settingRespository;
    }

    public async Task<StravaUser?> TokenExchangeAsync(string code)
    {
        var setting = await _settingRespository.FindSettingAsync();
        var clientId = setting?.ClientId.ToString();
        var clientSecret = setting?.ClientSecret;

        var token = await _stravaClient.GetAuthorizationTokenAsync(code, clientId, clientSecret);
        if (token?.Athlete == null)
        {
            return null;
        }

        _logger.LogInformation("Token: {}.", token.ToString());

        var u = await _stravaUserRepository.FindByAthleteIdAsync(token.Athlete.Id);
        if (u != null)
        {
            _logger.LogError($"Strava user with Athlete ID: {u.AthleteId} already exists.");

            return null;
        }

        var stravaUser = new StravaUser
        {
            AthleteId = token.Athlete.Id,
            Username = token.Athlete.Username,
            Firstname = token.Athlete.Firstname,
            Lastname = token.Athlete.Lastname,
            RefreshToken = token.RefreshToken,
            AccessToken = token.AccessToken,
            ExpiresAt = token.ExpiresAt
        };

        return await _stravaUserRepository.UpsertAsync(stravaUser);
    }

    public async Task<string?> CreateSubscriptionAsync()
    {
        var setting = await _settingRespository.FindSettingAsync();
        var clientId = setting?.ClientId.ToString();
        var clientSecret = setting?.ClientSecret;

        try
        {
            var response = await _stravaClient.CreateSubscriptionAsync(clientId, clientSecret);
            _logger.LogInformation("Subscription response: {}.", response);
            return response;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
        }

        return string.Empty;
    }

    public async Task<bool?> DeleteSubscriptionAsync()
    {
        var setting = await _settingRespository.FindSettingAsync();
        var clientId = setting?.ClientId.ToString();
        var clientSecret = setting?.ClientSecret;

        try
        {
            return await _stravaClient.DeleteSubscriptionAsync(clientId, clientSecret);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
        }

        return false;
    }

    public async Task<Subscription?> ViewSubscriptionAsync()
    {
        var setting = await _settingRespository.FindSettingAsync();
        var clientId = setting?.ClientId.ToString();
        var clientSecret = setting?.ClientSecret;

        try
        {
            return await _stravaClient.ViewSubscriptionAsync(clientId, clientSecret);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
        }

        return new Subscription();
    }

    public async Task<IEnumerable<Routes>> FindRoutesByAthleteIdAsync(long athleteId)
    {
        if (athleteId < 0)
        {
            _logger.LogError("Athlete ID: {} is invalid.", athleteId);

            return Array.Empty<Routes>();
        }

        var authorizationToken = await AuthorizationTokenByAthleteIdAsync(athleteId);
        return await _stravaClient.GetRoutesAsync(athleteId, authorizationToken);
    }

    public async Task<IEnumerable<Location>> FindLocationsByAthleteIdRouteIdAsync(long athleteId, long routeId)
    {
        if (athleteId < 0)
        {
            _logger.LogError("Athlete ID: {} is invalid.", athleteId);

            return Array.Empty<Location>();
        }

        if (routeId == -1)
        {
            _logger.LogError("Route ID: {} is invalid.", routeId);

            return Array.Empty<Location>();
        }

        var authorizationToken = await AuthorizationTokenByAthleteIdAsync(athleteId);

        var gpx = await _cache.GetStringAsync(routeId.ToString());
        if (string.IsNullOrEmpty(gpx))
        {
            gpx = await _stravaClient.GetGxpAsync(routeId, authorizationToken);
            await _cache.SetAsync(routeId.ToString(), DefaultEncoding.GetBytes(gpx), new DistributedCacheEntryOptions
            {
                AbsoluteExpiration = DateTimeOffset.Now.AddHours(CacheHours)
            });
            _logger.LogInformation("Cache gxp route with route ID: {}.", routeId);
        }

        if (string.IsNullOrEmpty(gpx))
        {
            _logger.LogError("Gxp is blank.");
            return Array.Empty<Location>();
        }

        var parsedLocations = GpxParser.GpxToLocations(gpx);
        _logger.LogInformation("Total locations: {}", parsedLocations.Count);

        var distances = DistanceHelper.GetEvenDistances(parsedLocations);
        var locations = distances.ToImmutableList();
        if (locations.Count <= MaxDistances)
        {
            return locations;
        }

        _logger.LogError("Even distances: {} exceed maximum: {}.", locations.Count, MaxDistances);

        return Array.Empty<Location>();
    }

    private async Task<string?> AuthorizationTokenByAthleteIdAsync(long athleteId)
    {
        if (athleteId < 0)
        {
            _logger.LogError("Athlete ID: {} is invalid.", athleteId);
            return null;
        }

        var stravaUser = await _stravaUserRepository.FindByAthleteIdAsync(athleteId);
        if (stravaUser == null)
        {
            _logger.LogError("No Strava user with athlete ID: {} was found.", athleteId);
            return null;
        }

        if (!IsTokenRefresh((long)stravaUser.ExpiresAt))
        {
            return stravaUser.AccessToken;
        }

        if (stravaUser.RefreshToken == null)
        {
            _logger.LogError("Refresh token for Strava user with athlete ID: {} is null.", athleteId);
            return null;
        }

        var authorizationToken = await RefreshTokenAsync(stravaUser.RefreshToken);
        stravaUser.AccessToken = authorizationToken?.AccessToken;
        stravaUser.ExpiresAt = authorizationToken?.ExpiresAt;
        stravaUser.RefreshToken = authorizationToken?.RefreshToken;

        await _stravaUserRepository.UpsertAsync(stravaUser);

        return authorizationToken?.AccessToken;
    }

    private async Task<AuthorizationToken?> RefreshTokenAsync(string refreshToken)
    {
        var setting = await _settingRespository.FindSettingAsync();
        var clientId = setting?.ClientId.ToString();
        var clientSecret = setting?.ClientSecret;

        return await _stravaClient.GetRefreshTokenAsync(refreshToken, clientId, clientSecret);
    }

    private static bool IsTokenRefresh(long expiresAt)
    {
        return DateTime.Now >= DateTime.UnixEpoch.AddSeconds(expiresAt).ToLocalTime();
    }
}