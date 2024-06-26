using MediatR;

namespace Centrix.Admin.Application.ServiceHealth.Get;

public class Handler : IRequestHandler<Query, Response>
{
    private readonly IServiceHealthFetcher _serviceHealthFetcher;

    public Handler(IServiceHealthFetcher serviceHealthFetcher)
    {
        _serviceHealthFetcher = serviceHealthFetcher;
    }

    public async Task<Response> Handle(Query query, CancellationToken cancellationToken)
    {
        var health = await _serviceHealthFetcher.FetchServiceHealth(query.ServiceId);

        return new Response()
        {
            ServiceId = health.ServiceId,
            Status = health.Status,
            Message = health.Message,
            LastUpdated = health.LastUpdated
        };
    }
}
