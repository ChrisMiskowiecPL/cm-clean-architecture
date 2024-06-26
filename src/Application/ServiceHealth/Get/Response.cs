using Centrix.Admin.Domain;

namespace Centrix.Admin.Application.ServiceHealth.Get;

public class Response 
{
  public Guid ServiceId { get; set; }
  public ServiceHealthStatus Status { get; set; }
  public string Message { get; set; }
  public DateTimeOffset LastUpdated { get; set; }
}
