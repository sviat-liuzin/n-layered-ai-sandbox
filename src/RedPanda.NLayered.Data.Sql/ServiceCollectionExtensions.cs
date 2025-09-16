using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RedPanda.NLayered.Data.Repositories;
using RedPanda.NLayered.Data.Sql.Repositories;

namespace RedPanda.NLayered.Data.Sql;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRedPandaNLayeredDataSql(
        this IServiceCollection services,
        string sqlSereverConnectionString)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(sqlSereverConnectionString));

        services.AddTransient<IMapRepository, MapRepository>();

        return services;
    }
}