namespace RedPanda.NLayered.Application.Map;

public interface IMapService
{
    Task<MyMapDto> GetMyMapAsync(CancellationToken cancellationToken = default);
}