using FronApiUs.Core.Contracts;
using FronApiUs.Core.Endpoints;
using FronApiUs.Core.Models;
using FronApiUs.Core.Parameters;
using MediatR;

namespace FronApiUs.Core.Requests;

public class GetNowSensorData : IFronApiUsRequest, IRequest<List<NowSensorData>>
{
    public GetNowSensorData(int deviceId)
    {
        var parameters = new SensorDataParameters(deviceId, FronApiUsConstants.DataCollection.SensorData.Now);
        Endpoint = new SensorDataEndpoint(parameters);
    }

    public IFronApiUsEndpoint<IFronApiUsParameters> Endpoint { get; }
}

public class GetNowSensorDataHandler : IRequestHandler<GetNowSensorData, List<NowSensorData>>
{
    private readonly IFronApiUsClient _fronApiUsClient;

    public GetNowSensorDataHandler(IFronApiUsClient fronApiUsClient)
    {
        _fronApiUsClient = fronApiUsClient;
    }

    public Task<List<NowSensorData>> Handle(GetNowSensorData request, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}