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
    private readonly IFronApiUsClient _froniusClient;

    public GetInverterInfoQueryHandler(IFronApiUsClient froniusClient)
    {
        _froniusClient = froniusClient;
    }

    public async Task<InverterInfo?> Handle(GetInverterInfo request, CancellationToken token)
    {
        return await _froniusClient.Get<InverterInfo>(request, token);
    }
}