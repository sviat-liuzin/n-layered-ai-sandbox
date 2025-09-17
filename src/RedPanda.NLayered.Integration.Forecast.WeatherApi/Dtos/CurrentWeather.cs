using System.Text.Json.Serialization;

namespace RedPanda.NLayered.Integration.Forecast.WeatherApi.Dtos;

public class CurrentWeather
{
    [JsonPropertyName("temp_c")]
    public double TempC { get; set; }

    [JsonPropertyName("temp_f")]
    public double TempF { get; set; }
}