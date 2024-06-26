using MyOrg.Admin.Application.ServiceHealth;
using MyOrg.Admin.Domain;

namespace MyOrg.Admin.Infrastructure;

public class ServiceHealthFetcher : IServiceHealthFetcher
{
    public Task<ServiceHealth> FetchServiceHealth(Guid serviceId)
    {
        // Call API
        return Task.FromResult(new ServiceHealth(
          serviceId,
          ServiceHealthStatus.Unknown,
          "Service health is stubbed",
          DateTimeOffset.UtcNow));
    }
}
