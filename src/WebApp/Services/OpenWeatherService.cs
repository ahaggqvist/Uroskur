using System.Globalization;
using System.Text;
using Microsoft.Extensions.Caching.Distributed;
using Uroskur.DataAccess.Repositories;
using Uroskur.Shared;
using Uroskur.Shared.Models.TemperaturesHourly;

namespace Uroskur.WebApp.Services;

public class OpenWeatherService : IOpenWeatherService
{
    private const int CacheHours = 1;
    private static readonly Encoding DefaultEncoding = new UTF8Encoding(false);
    private readonly IDistributedCache _cache;
    private readonly ILogger<OpenWeatherService> _logger;
    private readonly IOpenWeatherClient _openWeatherClient;
    private readonly ISettingRespository _settingRespository;
    private readonly IStravaService _stravaService;

    public OpenWeatherService(ILogger<OpenWeatherService> logger, IStravaService stravaService,
        IOpenWeatherClient openWeatherClient, IDistributedCache cache, ISettingRespository settingRespository)
    {
        _logger = logger;
        _stravaService = stravaService;
        _openWeatherClient = openWeatherClient;
        _cache = cache;
        _settingRespository = settingRespository;
    }

    public async Task<IEnumerable<Temperatures>> FindForecastAsync(long routeId, long athleteId)
    {
        var setting = await _settingRespository.FindSettingAsync();
        var appId = setting?.AppId;

        if (routeId < 0)
        {
            _logger.LogError("Route ID: {} is invalid.", routeId);
            return Array.Empty<Temperatures>();
        }

        if (athleteId < 0)
        {
            _logger.LogError("AthleteId ID: {} is invalid.", athleteId);
            return Array.Empty<Temperatures>();
        }

        var temperatures = new List<Temperatures>();

        var locations = (await _stravaService.FindLocationsByAthleteIdRouteIdAsync(athleteId, routeId)).ToList();
        foreach (var location in locations)
        {
            var key =
                $"{location.Lat.ToString(CultureInfo.InvariantCulture)}{location.Lon.ToString(CultureInfo.InvariantCulture)}";

            var json = await _cache.GetStringAsync(key);
            if (string.IsNullOrEmpty(json))
            {
                var temperature = await _openWeatherClient.GetForecastAsync(location, appId);
                if (temperature == null)
                {
                    continue;
                }

                await _cache.SetAsync(key, DefaultEncoding.GetBytes(temperature.ToJson()),
                    new DistributedCacheEntryOptions
                    {
                        AbsoluteExpiration = DateTimeOffset.Now.AddHours(CacheHours)
                    });

                _logger.LogInformation("Cache temperature with key: {}.", key);
                temperatures.Add(temperature);
            }
            else
            {
                var temperature = Temperatures.FromJson(json);
                if (temperature == null)
                {
                    continue;
                }

                _logger.LogInformation("Fetch cached temperature with key: {}.", key);
                temperatures.Add(temperature);
            }
        }

        return temperatures;
    }
}