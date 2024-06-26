using MediatR;
using MyOrg.Admin.Domain;

namespace MyOrg.Admin.Application.ServiceHealth.Get;

public class GetServiceHealthHandler : IRequestHandler<GetServiceHealthQuery, GetServiceHealthResponse>
{
    private readonly IServiceHealthFetcher _serviceHealthFetcher;

    public GetServiceHealthHandler(IServiceHealthFetcher serviceHealthFetcher)
    {
        _serviceHealthFetcher = serviceHealthFetcher;
    }

    public async Task<GetServiceHealthResponse> Handle(GetServiceHealthQuery query, CancellationToken cancellationToken)
    {
        var health = await _serviceHealthFetcher.FetchServiceHealth(query.ServiceId);

        return new GetServiceHealthResponse()
        {
            ServiceId = health.ServiceId,
            Status = health.Status,
            Message = health.Message,
            LastUpdated = health.LastUpdated
        };
    }
}
