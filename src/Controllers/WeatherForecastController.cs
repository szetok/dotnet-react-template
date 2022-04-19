using dotnet_react_template.Models;
using dotnet_react_template.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_react_template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IGetWeatherForecast _getWeatherForecast;

    public WeatherForecastController(IGetWeatherForecast getWeatherForecast)
        => _getWeatherForecast = getWeatherForecast;

    [HttpGet]
    public IEnumerable<WeatherForecast> Get() => _getWeatherForecast.Get();
}
