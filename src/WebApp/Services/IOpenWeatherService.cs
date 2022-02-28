using Uroskur.Shared.Models.TemperaturesHourly;

namespace Uroskur.WebApp.Services;

public interface IOpenWeatherService
{
    Task<IEnumerable<Temperatures>> FindForecastAsync(long routeId, long athleteId);
}