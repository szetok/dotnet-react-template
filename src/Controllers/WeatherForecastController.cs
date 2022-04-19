using DotnetReactTemplate.Models;
using DotnetReactTemplate.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotnetReactTemplate.Controllers;

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
