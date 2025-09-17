using System.Text.Json.Serialization;

namespace RedPanda.NLayered.Integration.Forecast.WeatherApi.Dtos;

public class CurrentWeatherResponse
{
    [JsonPropertyName("location")]
    public required Location Location { get; set; }

    [JsonPropertyName("current")]
    public required CurrentWeather CurrentWeather { get; set; }
}