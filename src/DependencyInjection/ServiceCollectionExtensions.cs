using dotnet_react_template.Services;

namespace dotnet_react_template.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTransientServices(this IServiceCollection services)
    {
        services.AddTransient<IGetWeatherForecast, GetWeatherForecast>();
        return services;
    }
}
