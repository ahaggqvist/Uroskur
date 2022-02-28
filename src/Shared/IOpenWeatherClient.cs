using Uroskur.Shared.Models;
using Uroskur.Shared.Models.TemperaturesHourly;

namespace Uroskur.Shared;

public interface IOpenWeatherClient
{
    Task<List<Temperatures>> GetForecastAsync(IEnumerable<Location>? locations, string? appId);
    Task<Temperatures?> GetForecastAsync(Location location, string? appId);
}