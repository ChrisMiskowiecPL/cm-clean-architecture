using MediatR;
using Centrix.Admin.Domain;

namespace Centrix.Admin.Application.ServiceHealth.Get;

public class Query : IRequest<Response>
{
  public Guid ServiceId { get; set; }
}
