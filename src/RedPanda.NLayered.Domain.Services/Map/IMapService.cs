using RedPanda.NLayered.Domain.Map;

namespace RedPanda.NLayered.Domain.Services.Map;

public interface IMapService
{
    Task<MyMap> UpdateMyMapForTodayAsync(double lastReportedTemperatureC, CancellationToken cancellationToken = default);
}