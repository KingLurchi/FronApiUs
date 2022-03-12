using FronApiUs.Core.Contracts;
using FronApiUs.Core.Endpoints;
using FronApiUs.Core.Models;
using FronApiUs.Core.Parameters;
using MediatR;

namespace FronApiUs.Core.Requests;

public class GetMinMaxInverterData : IFronApiUsRequest, IRequest<MinMaxInverterData?>
{
    public GetMinMaxInverterData(int deviceId)
    {
        var parameters = new InverterDataParameters(deviceId, FronApiUsConstants.DataCollection.InverterData.MinMax);
        Endpoint = new InverterDataEndpoint(parameters);
    }

    public IFronApiUsEndpoint<IFronApiUsParameters> Endpoint { get; }
}

public class GetMinMaxInverterDataHandler : IRequestHandler<GetMinMaxInverterData, MinMaxInverterData?>
{
    private readonly IFronApiUsClient _froniusClient;

    public GetMinMaxInverterDataHandler(IFronApiUsClient froniusClient)
    {
        _froniusClient = froniusClient;
    }

    public async Task<MinMaxInverterData?> Handle(GetMinMaxInverterData request, CancellationToken token)
        => await _froniusClient.Get<MinMaxInverterData>(request, token);
}