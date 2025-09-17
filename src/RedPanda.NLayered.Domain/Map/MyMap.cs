using EnsureThat;

namespace RedPanda.NLayered.Domain.Map;

public class MyMap(
    Guid id,
    DateOnly date,
    string mapData,
    double? lastReportedTemperatureC)
{
    public Guid Id { get; } = Ensure.Any.IsNotDefault(id, nameof(id));

    public DateOnly Date { get; } = Ensure.Any.IsNotDefault(date, nameof(date));

    public string MapData { get; }  = Ensure.Any.IsNotNull(mapData, nameof(mapData));

    public double? LastReportedTemperatureC { get; private set; } = lastReportedTemperatureC;

    public void UpdateLastReportedTemperatureC(double temperatureC)
    {
        LastReportedTemperatureC = temperatureC;
    }
}