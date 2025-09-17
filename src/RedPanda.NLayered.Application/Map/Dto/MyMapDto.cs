using EnsureThat;

namespace RedPanda.NLayered.Application.Map.Dto;

public class MyMapDto(
    DateOnly date,
    string mapData,
    double? lastReportedTemperatureC)
{
    public DateOnly Date { get; } = Ensure.Any.IsNotDefault(date, nameof(date));

    public string MapData { get; }  = Ensure.Any.IsNotNull(mapData, nameof(mapData));

    public double? LastReportedTemperatureC { get; private set; } = lastReportedTemperatureC;

}
