using Centrix.Admin.Application.ServiceHealth;
using Centrix.Admin.Domain;

namespace Centrix.Admin.Infrastructure;

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
