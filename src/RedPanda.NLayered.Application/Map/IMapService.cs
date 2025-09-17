using RedPanda.NLayered.Application.Map.Dto;

namespace RedPanda.NLayered.Application.Map;

public interface IMapService
{
    Task<MyMapDto> UpdateMyMapForTodayAsync(CancellationToken cancellationToken = default);
}