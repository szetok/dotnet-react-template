using Microsoft.AspNetCore.Mvc;
using dotnet_react_template.Models;
using dotnet_react_template.Services;

namespace dotnet_react_template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IGetWeatherForecast _getWeatherForecast;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IGetWeatherForecast getWeatherForecast)
    {
        _logger = logger;
        _getWeatherForecast = getWeatherForecast;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get() => _getWeatherForecast.Get();
}
