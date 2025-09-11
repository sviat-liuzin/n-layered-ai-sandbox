using AutoMapper;
using EnsureThat;
using DomainMapService = RedPanda.NLayered.Domain.Services.Map.IMapService;

namespace RedPanda.NLayered.Application.Map;

internal class MapService(
    DomainMapService domainMapService,
    IMapper mapper) : IMapService
{
    public readonly DomainMapService _domainMapService = Ensure.Any.IsNotNull(domainMapService, nameof(domainMapService));
    public readonly IMapper _mapper = Ensure.Any.IsNotNull(mapper, nameof(mapper));

    public async Task<MyMapDto> GetMyMapAsync(CancellationToken cancellationToken = default)
    {
        var domainMap = await _domainMapService.GetMyMapAsync(cancellationToken);
        var mapDto = _mapper.Map<MyMapDto>(domainMap);

        return mapDto;
    }
}