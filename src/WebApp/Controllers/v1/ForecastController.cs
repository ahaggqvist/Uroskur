using Microsoft.AspNetCore.Mvc;
using Uroskur.WebApp.Services;

namespace Uroskur.WebApp.Controllers.v1;

[Route("api/v1/[controller]/[action]")]
[ApiController]
public class ForecastController : ControllerBase
{
    private readonly IOpenWeatherService _openWeatherService;

    public ForecastController(IOpenWeatherService openWeatherService)
    {
        _openWeatherService = openWeatherService;
    }

    [HttpGet]
    public async Task<IActionResult> Forecast(long routeId, long athleteId)
    {
        return Ok(await _openWeatherService.FindForecastAsync(routeId, athleteId));
    }
}