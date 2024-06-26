using Microsoft.Extensions.DependencyInjection;
using MyOrg.Admin.Domain;

namespace MyOrg.Admin.Infrastructure;

public static class InfrastructureServiceExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IServiceHealthFetcher, ServiceHealthFetcher>();
        return services;
    }
}