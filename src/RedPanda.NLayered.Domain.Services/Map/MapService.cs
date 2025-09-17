using EnsureThat;
using RedPanda.NLayered.Data.Repositories;
using RedPanda.NLayered.Domain.Map;

namespace RedPanda.NLayered.Domain.Services.Map;

internal class MapService(IMapRepository mapRepository) : IMapService
{
    private readonly IMapRepository _mapRepository = Ensure.Any.IsNotNull(mapRepository, nameof(mapRepository));

    public async Task<MyMap> UpdateMyMapForTodayAsync(double lastReportedTemperatureC, CancellationToken cancellationToken = default)
    {
        var now = DateTime.Now;
        var today = DateOnly.FromDateTime(now);

        var myMap = await _mapRepository.GetMyMapAsync(today, cancellationToken);
        if (myMap == null)
        {
            myMap = new MyMap(Guid.NewGuid(), today, "Some important map data.", lastReportedTemperatureC);

            await _mapRepository.CreateMyMapAsync(myMap);
        }
        else
        {
            myMap.UpdateLastReportedTemperatureC(lastReportedTemperatureC);

            await _mapRepository.UpdateMyMapAsync(myMap);
        }

        return myMap;
    }
}