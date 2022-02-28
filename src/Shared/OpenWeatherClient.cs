using System.Collections.Immutable;
using System.Globalization;
using Polly;
using Uroskur.Shared.Models;
using Uroskur.Shared.Models.TemperaturesHourly;

namespace Uroskur.Shared;

public class OpenWeatherClient : IOpenWeatherClient
{
    private const int MaxLocations = 10;
    private const int MaxRetryAttempts = 3;
    private const int PauseBetweenFailures = 2;
    private readonly AppSettings? _appSettings;
    private readonly HttpClient _httpClient;

    public OpenWeatherClient(AppSettings? appSettings, HttpClient httpClient)
    {
        _appSettings = appSettings;
        _httpClient = httpClient;
    }

    public async Task<List<Temperatures>> GetForecastAsync(IEnumerable<Location>? locations, string? appId)
    {
        if (locations == null)
        {
            throw new ArgumentException("Locations are null.");
        }

        locations = locations.ToImmutableList();
        if (locations.Count() > MaxLocations)
        {
            throw new ArgumentException("Locations exceed maximum.");
        }

        if (string.IsNullOrEmpty(appId))
        {
            throw new ArgumentException("App ID is invalid.");
        }

        var forecastUrl = _appSettings?.ForecastUrl;
        if (string.IsNullOrEmpty(forecastUrl))
        {
            throw new ArgumentException("Forecast url is invalid.");
        }

        var pauseBetweenFailures = TimeSpan.FromSeconds(PauseBetweenFailures);
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .WaitAndRetryAsync(MaxRetryAttempts, _ => pauseBetweenFailures);

        // hourly,minutely,daily,alerts
        // current,minutely,daily,alerts
        var urls = locations.Select(location => forecastUrl
                .Replace("@AppId", appId)
                .Replace("@Exclude", "hourly,minutely,daily,alerts")
                .Replace("@Lat", location.Lat.ToString(CultureInfo.InvariantCulture))
                .Replace("@Lon", location.Lon.ToString(CultureInfo.InvariantCulture)))
            .ToList();

        var temperatures = new List<Temperatures>();
        await retryPolicy.ExecuteAsync(async () =>
        {
            var responses = urls.Select(GetResponseAsync).ToArray();
            Task.WhenAll(responses).Wait(60000);

            foreach (var response in responses)
            {
                if (Temperatures.FromJson(await response) is { } t)
                {
                    temperatures.Add(t);
                }
            }
        });

        return temperatures;
    }

    public async Task<Temperatures?> GetForecastAsync(Location location, string? appId)
    {
        if (location == null)
        {
            throw new ArgumentException("Location is null.");
        }

        if (string.IsNullOrEmpty(appId))
        {
            throw new ArgumentException("App ID is invalid.");
        }

        var forecastUrl = _appSettings?.ForecastUrl;
        if (string.IsNullOrEmpty(forecastUrl))
        {
            throw new ArgumentException("Forecast url is invalid.");
        }

        var pauseBetweenFailures = TimeSpan.FromSeconds(PauseBetweenFailures);
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .WaitAndRetryAsync(MaxRetryAttempts, _ => pauseBetweenFailures);

        var url = forecastUrl
            .Replace("@AppId", appId)
            .Replace("@Lat", location.Lat.ToString(CultureInfo.InvariantCulture))
            .Replace("@Lon", location.Lon.ToString(CultureInfo.InvariantCulture));

        Temperatures? temperatures = null;
        await retryPolicy.ExecuteAsync(async () =>
        {
            temperatures = Temperatures.FromJson(await GetResponseAsync(url));
        });


        return temperatures;
    }

    private async Task<string> GetResponseAsync(string? url)
    {
        return await _httpClient.GetStringAsync(url);
    }
}