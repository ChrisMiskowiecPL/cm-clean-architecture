namespace Centrix.Admin.Application.ServiceHealth;

public interface IServiceHealthFetcher
{
  Task<Domain.ServiceHealth> FetchServiceHealth(Guid serviceId);
}