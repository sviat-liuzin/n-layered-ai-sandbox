using Microsoft.Extensions.DependencyInjection;
using RedPanda.NLayered.Application.Map;
using RedPanda.NLayered.Domain.Services;

namespace RedPanda.NLayered.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRedPandaNLayeredApplication(this IServiceCollection services)
    {
        services.AddTransient<IMapService, MapService>();

        services.AddRedpandaDomainServices();

        return services;
    }
}