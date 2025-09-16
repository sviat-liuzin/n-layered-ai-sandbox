using EnsureThat;
using RedPanda.NLayered.Data.Repositories;
using RedPanda.NLayered.Domain.Map;

namespace RedPanda.NLayered.Domain.Services.Map;

internal class MapService(IMapRepository mapRepository) : IMapService
{
    private readonly IMapRepository _mapRepository = Ensure.Any.IsNotNull(mapRepository, nameof(mapRepository));

    public async Task<MyMap> GetMyMapAsync(CancellationToken cancellationToken = default)
    {
        var myMap = await _mapRepository.GetMyMapAsync(cancellationToken);

        return myMap;
    }
}