using MyOrg.Admin.Domain;

namespace MyOrg.Admin.Application.ServiceHealth.Get;

public class GetServiceHealthResponse 
{
  public Guid ServiceId { get; set; }
  public ServiceHealthStatus Status { get; set; }
  public string Message { get; set; }
  public DateTimeOffset LastUpdated { get; set; }
}
