using FronApiUs.Core.Contracts;
using FronApiUs.Core.Endpoints;
using FronApiUs.Core.Models;
using FronApiUs.Core.Parameters;
using MediatR;

namespace FronApiUs.Core.Requests;

public class GetCumulationInverterData : IFronApiUsRequest, IRequest<CumulationInverterData?>
{
    public GetCumulationInverterData(int deviceId)
    {
        var parameters = new InverterDataParameters(deviceId, FronApiUsConstants.DataCollection.InverterData.Cumulation);
        Endpoint = new InverterDataEndpoint(parameters);
    }

    public IFronApiUsEndpoint<IFronApiUsParameters> Endpoint { get; }
}

public class GetCumulationInverterDataHandler : IRequestHandler<GetCumulationInverterData, CumulationInverterData?>
{
    private readonly IFronApiUsClient _fronApiUsClient;

    public GetCumulationInverterDataHandler(IFronApiUsClient fronApiUsClient)
    {
        _fronApiUsClient = fronApiUsClient;
    }

    public async Task<CumulationInverterData?> Handle(GetCumulationInverterData request, CancellationToken token)
    {
        return await _fronApiUsClient.Get<CumulationInverterData>(request, token);
    }
}