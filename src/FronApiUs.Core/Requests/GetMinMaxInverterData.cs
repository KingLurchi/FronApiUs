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
    private readonly IFronApiUsClient _fronApiUsClient;

    public GetMinMaxInverterDataHandler(IFronApiUsClient fronApiUsClient)
    {
        _fronApiUsClient = fronApiUsClient;
    }

    public async Task<MinMaxInverterData?> Handle(GetMinMaxInverterData request, CancellationToken token)
    {
        return await _fronApiUsClient.Get<MinMaxInverterData>(request, token);
    }
}