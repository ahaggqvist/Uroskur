namespace Uroskur.Shared.Models;

public class AppSettings
{
    public string StravaAuthorizationTokenUrl { get; set; } = "https://www.strava.com/oauth/token";

    public string StravaSubscriptionUrl { get; set; } = "https://www.strava.com/api/v3/push_subscriptions";

    public string StravaRoutesUrl { get; set; } = "https://www.strava.com/api/v3/athletes/@AthleteId/routes";

    public string StravaGxpUrl { get; set; } = "https://www.strava.com/api/v3/routes/@RouteId/export_gpx";

    public string? StravaCallbackUrl { get; set; }


    public string? StravaClientId { get; set; }

    public string? StravaClientSecret { get; set; }

    public string ForecastUrl { get; set; } =
        "https://api.openweathermap.org/data/2.5/onecall?lat=@Lat&lon=@Lon&exclude=@Exclude&units=metric&appid=@AppId";

    public string? OpenWeatherAppId { get; set; }
}