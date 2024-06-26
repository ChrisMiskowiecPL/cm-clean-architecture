namespace MyOrg.Admin.Application.ServiceHealth;

public interface IServiceHealthFetcher
{
  Task<Domain.ServiceHealth> FetchServiceHealth(Guid serviceId);
}