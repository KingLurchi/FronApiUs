using FronApiUs.Core.Contracts;
using FronApiUs.Core.Endpoints;
using FronApiUs.Core.Models;
using FronApiUs.Core.Parameters;
using MediatR;

namespace FronApiUs.Core.Requests;

public class GetCommonInverterData : IFronApiUsRequest, IRequest<CommonInverterData?>
{
    public GetCommonInverterData(int deviceId)
    {
        var parameters = new InverterDataParameters(deviceId, FronApiUsConstants.DataCollection.InverterData.Common);
        Endpoint = new InverterDataEndpoint(parameters);
    }

    public IFronApiUsEndpoint<IFronApiUsParameters> Endpoint { get; }
}

public class GetCommonInverterDataHandler : IRequestHandler<GetCommonInverterData, CommonInverterData?>
{
    private readonly IFronApiUsClient _froniusClient;

    public GetCommonInverterDataHandler(IFronApiUsClient froniusClient)
    {
        _froniusClient = froniusClient;
    }

    public async Task<CommonInverterData?> Handle(GetCommonInverterData request, CancellationToken token)
        => await _froniusClient.Get<CommonInverterData>(request, token);
}