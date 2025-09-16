using EnsureThat;
using Microsoft.EntityFrameworkCore;
using RedPanda.NLayered.Data.Repositories;
using RedPanda.NLayered.Domain.Map;

namespace RedPanda.NLayered.Data.Sql.Repositories;

internal class MapRepository(ApplicationDbContext dbContext) : IMapRepository
{
    private readonly ApplicationDbContext _dbContext = Ensure.Any.IsNotNull(dbContext, nameof(dbContext));

    private DbSet<MyMap> MyMaps => _dbContext.Set<MyMap>();

    public async Task<MyMap> GetMyMapAsync(CancellationToken cancellationToken = default)
    {
        var result = await MyMaps.FirstOrDefaultAsync(cancellationToken);

        return result;
    }
}