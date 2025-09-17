using System.Net.Http.Json;
using EnsureThat;
using RedPanda.NLayered.Integration.Forecast.WeatherApi.Dtos;

namespace RedPanda.NLayered.Integration.Forecast.WeatherApi;

internal class WeatherApiClient : IWeatherApiClient
{
    public WeatherApiClient(
        HttpClient httpClient,
        WeatherApiClientOptions options)
    {
        _httpClient = Ensure.Any.IsNotNull(httpClient, nameof(httpClient));
        _options = Ensure.Any.IsNotNull(options, nameof(options));

        _httpClient.BaseAddress = new Uri(options.BaseUrl);
    }

    private readonly HttpClient _httpClient;

    private readonly WeatherApiClientOptions _options;

    public async Task<CurrentWeatherResponse> GetCurrentWeatherAsync(string cityName, CancellationToken cancellationToken = default)
    {
        Ensure.String.IsNotEmptyOrWhiteSpace(cityName, nameof(cityName));

        var response = await _httpClient.GetAsync($"v1/current.json?key={_options.ApiKey}&q={cityName}&aqi=no");
        var responseDto = await response.Content.ReadFromJsonAsync<CurrentWeatherResponse>();

        return responseDto;
    }
}