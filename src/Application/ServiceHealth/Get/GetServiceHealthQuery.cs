using MediatR;

namespace MyOrg.Admin.Application.ServiceHealth.Get;

public class GetServiceHealthQuery : IRequest<GetServiceHealthResponse>
{
  public Guid ServiceId { get; set; }
}
