using EnsureThat;

namespace RedPanda.NLayered.Integration.Forecast.WeatherApi;

public class WeatherApiClientOptions(string baseUrl, string apiKey)
{
    public string BaseUrl { get; } = Ensure.String.IsNotEmptyOrWhiteSpace(baseUrl, nameof(baseUrl));

    public string ApiKey { get; } = Ensure.String.IsNotEmptyOrWhiteSpace(apiKey, nameof(apiKey));
}