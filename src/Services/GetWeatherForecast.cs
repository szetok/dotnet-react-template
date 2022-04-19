using Microsoft.AspNetCore.Mvc;
using dotnet_react_template.Models;

namespace dotnet_react_template.Services;

public interface IGetWeatherForecast
{
    IEnumerable<WeatherForecast> Get();
}

public class GetWeatherForecast : IGetWeatherForecast
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
