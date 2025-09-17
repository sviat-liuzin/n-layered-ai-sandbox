using System.Text.Json.Serialization;

namespace RedPanda.NLayered.Integration.Forecast.WeatherApi.Dtos;

public class Location
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("region")]
    public required string Region { get; set; }

    [JsonPropertyName("country")]
    public required string Country { get; set; }

    [JsonPropertyName("lat")]
    public required double Latitude { get; set; }

    [JsonPropertyName("lon")]
    public required double Longitude { get; set; }
}