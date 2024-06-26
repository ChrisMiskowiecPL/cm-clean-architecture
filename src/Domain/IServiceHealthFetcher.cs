namespace MyOrg.Admin.Domain;

public interface IServiceHealthFetcher
{
  Task<ServiceHealth> FetchServiceHealth(Guid serviceId);
}