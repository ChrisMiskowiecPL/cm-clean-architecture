namespace Centrix.Admin.Domain;

public class ServiceHealth
{
    public Guid ServiceId { get; private set; }
    public ServiceHealthStatus Status { get; private set; }
    public string Message { get; private set; }
    public DateTimeOffset LastUpdated { get; private set; }

    public ServiceHealth(Guid serviceId, ServiceHealthStatus status, string message, DateTimeOffset lastUpdated)
    {
        ServiceId = serviceId;
        Status = status;
        Message = message;
        LastUpdated = lastUpdated;
    }

    public void Update(ServiceHealthStatus status, string message, DateTimeOffset lastUpdated)
    {
        Status = status;
        Message = message;
        LastUpdated = lastUpdated;
    }
}
