using FronApiUs.Core.Contracts;
using FronApiUs.Core.Endpoints;
using FronApiUs.Core.Models;
using FronApiUs.Core.Parameters;
using MediatR;

namespace FronApiUs.Core.Requests;

public class GetThreePhaseInverterData : IFronApiUsRequest, IRequest<ThreePhaseInverterData?>
{
    public GetThreePhaseInverterData(int deviceId)
    {
        var parameters = new InverterDataParameters(deviceId, FronApiUsConstants.DataCollection.InverterData.ThreePhase);
        Endpoint = new InverterDataEndpoint(parameters);
    }

    public IFronApiUsEndpoint<IFronApiUsParameters> Endpoint { get; }
}

public class GetThreePhaseInverterDataHandler : IRequestHandler<GetThreePhaseInverterData, ThreePhaseInverterData?>
{
    private readonly IFronApiUsClient _froniusClient;

    public GetThreePhaseInverterDataHandler(IFronApiUsClient froniusClient)
    {
        _froniusClient = froniusClient;
    }

    public async Task<ThreePhaseInverterData?> Handle(GetThreePhaseInverterData request, CancellationToken token)
        => await _froniusClient.Get<ThreePhaseInverterData>(request, token);
}