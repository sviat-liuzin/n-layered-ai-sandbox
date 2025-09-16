using Microsoft.Extensions.DependencyInjection;
using RedPanda.NLayered.Domain.Services.Map;

namespace RedPanda.NLayered.Domain.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRedpandaDomainServices(this IServiceCollection services)
    {
        services.AddTransient<IMapService, MapService>();

        return services;
    }
}