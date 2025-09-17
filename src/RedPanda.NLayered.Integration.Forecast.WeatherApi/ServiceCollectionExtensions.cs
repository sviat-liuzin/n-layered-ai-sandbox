using Microsoft.Extensions.DependencyInjection;

namespace RedPanda.NLayered.Integration.Forecast.WeatherApi;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddWeatherApi(this IServiceCollection services, WeatherApiClientOptions weatherApiClientOptions)
    {
        services.AddHttpClient<IWeatherApiClient, WeatherApiClient>();
        services.AddSingleton(weatherApiClientOptions);

        return services;
    }
}