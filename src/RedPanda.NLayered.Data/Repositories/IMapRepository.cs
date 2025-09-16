using RedPanda.NLayered.Domain.Map;

namespace RedPanda.NLayered.Data.Repositories;

public interface IMapRepository
{
    Task<MyMap> GetMyMapAsync(CancellationToken cancellationToken = default);
}