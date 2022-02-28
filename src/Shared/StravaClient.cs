using System.Net;
using System.Net.Http.Headers;
using Polly;
using Uroskur.Shared.Models;

namespace Uroskur.Shared;

public class StravaClient : IStravaClient
{
    private const string GrantTypeAuthorizationCode = "authorization_code";
    private const string GrantTypeRefreshToken = "refresh_token";
    private const int MaxRetryAttempts = 3;
    private const int PauseBetweenFailures = 2;
    private readonly AppSettings? _appSettings;
    private readonly HttpClient _httpClient;

    public StravaClient(AppSettings? appSettings, HttpClient httpClient)
    {
        _appSettings = appSettings;
        _httpClient = httpClient;
    }

    public async Task<AuthorizationToken?> GetAuthorizationTokenAsync(string? code, string? clientId,
        string? clientSecret)
    {
        if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(clientSecret))
        {
            throw new ArgumentException("Code, Client ID, Client secret are invalid.");
        }

        var authorizationTokenUrl = _appSettings?.StravaAuthorizationTokenUrl;
        if (string.IsNullOrEmpty(authorizationTokenUrl))
        {
            throw new ArgumentException("Authorization token url is invalid.");
        }

        var formUrlEncodedContent = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            { "client_id", clientId },
            { "client_secret", clientSecret },
            { "code", code },
            { "grant_type", GrantTypeAuthorizationCode }
        });

        var response = await _httpClient.PostAsync(authorizationTokenUrl, formUrlEncodedContent);
        response.EnsureSuccessStatusCode();
        var responseBody = await response.Content.ReadAsStringAsync();

        return !string.IsNullOrEmpty(responseBody) ? AuthorizationToken.FromJson(responseBody) : null;
    }

    public async Task<string?> CreateSubscriptionAsync(string? clientId, string? clientSecret)
    {
        if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(clientSecret))
        {
            throw new ArgumentException("Client ID and Client secret are invalid.");
        }

        var callbackUrl = _appSettings?.StravaCallbackUrl;
        if (string.IsNullOrEmpty(callbackUrl))
        {
            throw new ArgumentException("Callback url is invalid.");
        }

        var subscriptionUrl = _appSettings?.StravaSubscriptionUrl;
        if (string.IsNullOrEmpty(subscriptionUrl))
        {
            throw new ArgumentException("Subscription url is invalid.");
        }

        var formUrlEncodedContent = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            { "client_id", clientId },
            { "client_secret", clientSecret },
            { "callback_url", callbackUrl },
            { "verify_token", "uroskur" }
        });

        var response = await _httpClient.PostAsync(subscriptionUrl, formUrlEncodedContent);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<bool?> DeleteSubscriptionAsync(string? clientId, string? clientSecret)
    {
        if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(clientSecret))
        {
            throw new ArgumentException("Client ID and Client secret are invalid.");
        }

        var subscriptionUrl = _appSettings?.StravaSubscriptionUrl;
        if (string.IsNullOrEmpty(subscriptionUrl))
        {
            throw new ArgumentException("Subscription url is invalid.");
        }

        var subscription = await ViewSubscriptionAsync(clientId, clientSecret);

        var pauseBetweenFailures = TimeSpan.FromSeconds(PauseBetweenFailures);
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .WaitAndRetryAsync(MaxRetryAttempts, _ => pauseBetweenFailures);

        using var request = new HttpRequestMessage(HttpMethod.Delete,
            $"{subscriptionUrl}/{subscription?.Id}?client_id={clientId}&client_secret={clientSecret}");

        var isDeleted = false;
        await retryPolicy.ExecuteAsync(async () =>
        {
            var response = await GetResponseAsync(request);
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                isDeleted = true;
            }
        });

        return isDeleted;
    }

    public async Task<Subscription?> ViewSubscriptionAsync(string? clientId, string? clientSecret)
    {
        if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(clientSecret))
        {
            throw new ArgumentException("Client ID and Client secret are invalid.");
        }

        var subscriptionUrl = _appSettings?.StravaSubscriptionUrl;
        if (string.IsNullOrEmpty(subscriptionUrl))
        {
            throw new ArgumentException("Subscription url is invalid.");
        }

        var pauseBetweenFailures = TimeSpan.FromSeconds(PauseBetweenFailures);
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .WaitAndRetryAsync(MaxRetryAttempts, _ => pauseBetweenFailures);

        using var request = new HttpRequestMessage(HttpMethod.Get,
            $"{subscriptionUrl}?client_id={clientId}&client_secret={clientSecret}");

        var subscriptions = new List<Subscription>();
        await retryPolicy.ExecuteAsync(async () =>
        {
            var response = await GetResponseAsync(request);
            if (response.IsSuccessStatusCode)
            {
                subscriptions = Subscription.FromJson(await response.Content.ReadAsStringAsync());
            }
        });

        return subscriptions.FirstOrDefault();
    }

    public async Task<AuthorizationToken?> GetRefreshTokenAsync(string? refreshToken, string? clientId,
        string? clientSecret)
    {
        if (string.IsNullOrEmpty(refreshToken) || string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(clientSecret))
        {
            throw new ArgumentException("Refresh token, Client ID and Client secret are invalid.");
        }

        var authorizationTokenUrl = _appSettings?.StravaAuthorizationTokenUrl;
        if (string.IsNullOrEmpty(authorizationTokenUrl))
        {
            throw new ArgumentException("Authorization token url is invalid.");
        }

        var formUrlEncodedContent = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            { "client_id", clientId },
            { "client_secret", clientSecret },
            { "grant_type", GrantTypeRefreshToken },
            { "refresh_token", refreshToken }
        });

        var response = await _httpClient.PostAsync(authorizationTokenUrl, formUrlEncodedContent);
        response.EnsureSuccessStatusCode();
        var responseBody = await response.Content.ReadAsStringAsync();

        return !string.IsNullOrEmpty(responseBody) ? AuthorizationToken.FromJson(responseBody) : null;
    }

    public async Task<IEnumerable<Routes>> GetRoutesAsync(long athleteId, string? authorizationToken)
    {
        if (string.IsNullOrEmpty(authorizationToken))
        {
            throw new ArgumentException("Authorization token is invalid.");
        }

        var routesUrl = _appSettings?.StravaRoutesUrl;
        if (string.IsNullOrEmpty(routesUrl))
        {
            throw new ArgumentException("Routes url is invalid.");
        }

        var pauseBetweenFailures = TimeSpan.FromSeconds(PauseBetweenFailures);
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .WaitAndRetryAsync(MaxRetryAttempts, _ => pauseBetweenFailures);

        var url = routesUrl.Replace("@AthleteId", athleteId.ToString());
        using var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authorizationToken);

        var routes = new List<Routes>();
        await retryPolicy.ExecuteAsync(async () =>
        {
            var response = await GetResponseAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var routesList = Routes.FromJson(await response.Content.ReadAsStringAsync());
                if (routesList != null)
                {
                    routes.AddRange(routesList);
                }
            }
        });

        return routes;
    }

    public async Task<string> GetGxpAsync(long routeId, string? authorizationToken)
    {
        if (string.IsNullOrEmpty(authorizationToken))
        {
            throw new ArgumentException("Authorization token is invalid.");
        }

        var gxpUrl = _appSettings?.StravaGxpUrl;
        if (string.IsNullOrEmpty(gxpUrl))
        {
            throw new ArgumentException("Gxp url is invalid.");
        }

        var pauseBetweenFailures = TimeSpan.FromSeconds(PauseBetweenFailures);
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .WaitAndRetryAsync(MaxRetryAttempts, _ => pauseBetweenFailures);

        var url = gxpUrl.Replace("@RouteId", routeId.ToString());
        using var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authorizationToken);

        var xml = string.Empty;
        await retryPolicy.ExecuteAsync(async () =>
        {
            var response = await GetResponseAsync(request);
            if (response.IsSuccessStatusCode)
            {
                xml = await response.Content.ReadAsStringAsync();
            }
        });

        return xml;
    }

    private async Task<HttpResponseMessage> GetResponseAsync(HttpRequestMessage url)
    {
        return await _httpClient.SendAsync(url);
    }
}