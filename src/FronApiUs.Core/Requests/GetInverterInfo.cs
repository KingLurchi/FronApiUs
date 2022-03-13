using FronApiUs.Core.Contracts;
using FronApiUs.Core.Endpoints;
using FronApiUs.Core.Models;
using MediatR;

namespace FronApiUs.Core.Requests;

public class GetInverterInfo : IFronApiUsRequest, IRequest<InverterInfo?>
{
    public IFronApiUsEndpoint<IFronApiUsParameters> Endpoint => new InverterInfoEndpoint();
}

public class GetInverterInfoQueryHandler : IRequestHandler<GetInverterInfo, InverterInfo?>
{
    private readonly IFronApiUsClient _fronApiUsClient;

    public GetInverterInfoQueryHandler(IFronApiUsClient fronApiUsClient)
    {
        _fronApiUsClient = fronApiUsClient;
    }

    public async Task<InverterInfo?> Handle(GetInverterInfo request, CancellationToken token)
    {
        return await _fronApiUsClient.Get<InverterInfo>(request, token);
    }
}