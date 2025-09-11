namespace RedPanda.NLayered.Domain.Services.Map;

public interface IMapService
{
    Task<MyMap> GetMyMapAsync(CancellationToken cancellationToken = default);
}