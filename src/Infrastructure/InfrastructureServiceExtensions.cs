using MyOrg.Admin.Application.ServiceHealth;
using Microsoft.Extensions.DependencyInjection;

namespace MyOrg.Admin.Infrastructure;

public static class InfrastructureServiceExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IServiceHealthFetcher, ServiceHealthFetcher>();
        return services;
    }
}