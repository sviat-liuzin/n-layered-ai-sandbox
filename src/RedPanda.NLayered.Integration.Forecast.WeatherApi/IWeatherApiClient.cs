using RedPanda.NLayered.Integration.Forecast.WeatherApi.Dtos;

namespace RedPanda.NLayered.Integration.Forecast.WeatherApi;

public interface IWeatherApiClient
{
    Task<CurrentWeatherResponse> GetCurrentWeatherAsync(string cityName, CancellationToken cancellationToken = default);
}