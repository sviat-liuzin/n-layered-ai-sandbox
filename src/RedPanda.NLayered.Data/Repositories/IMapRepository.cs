using RedPanda.NLayered.Domain.Map;

namespace RedPanda.NLayered.Data.Repositories;

public interface IMapRepository
{
    Task<MyMap?> GetMyMapAsync(DateOnly date, CancellationToken cancellationToken = default);

    Task CreateMyMapAsync(MyMap myMap);

    Task UpdateMyMapAsync(MyMap myMap);
}