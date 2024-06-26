using MyOrg.Admin.Application.ServiceHealth.Get;
using MediatR;

namespace MyOrg.Admin.Api.Endpoints;

public static class ServicesEndpoints
{
    public static void Map(WebApplication app)
    {
        var services = app.MapGroup("services");

        services.Map("{serviceId}", GetServiceHealth);
    }

    private static async Task<GetServiceHealthResponse> GetServiceHealth(Guid serviceId, IMediator mediator)
    {
        var query = new GetServiceHealthQuery() { ServiceId = serviceId };
        return await mediator.Send(query);
    }
}