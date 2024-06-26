using Centrix.Admin.Domain;
using Centrix.Admin.Application.ServiceHealth.Get;
using MediatR;

namespace Centrix.Admin.Api.Endpoints;

public class ServicesEndpoints
{
    public void Map(WebApplication app)
    {
        var services = app.MapGroup("services");

        services.Map("{serviceId}", GetServiceHealth);
    }

    private static async Task<Response> GetServiceHealth(Guid serviceId, IMediator mediator)
    {
        var query = new Query() { ServiceId = serviceId };
        return await mediator.Send(query);
    }
}