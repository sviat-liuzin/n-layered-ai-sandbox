using Microsoft.Extensions.DependencyInjection;
using RedPanda.NLayered.Application.Map;
using RedPanda.NLayered.Domain.Services;
using RedPanda.NLayered.Integration.Forecast.WeatherApi;

namespace RedPanda.NLayered.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRedPandaNLayeredApplication(
        this IServiceCollection services,
        WeatherApiClientOptions weatherApiClientOptions)
    {
        services.AddTransient<IMapService, MapService>();

        services.AddRedpandaDomainServices();
        services.AddWeatherApi(weatherApiClientOptions);

        return services;
    }
}