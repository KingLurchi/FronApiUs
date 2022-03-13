using FronApiUs.Core.Contracts;
using FronApiUs.Core.Endpoints;
using FronApiUs.Core.Models;
using FronApiUs.Core.Parameters;
using MediatR;

namespace FronApiUs.Core.Requests;

public class GetMinMaxSensorData : IFronApiUsRequest, IRequest<List<MinMaxSensorData>>
{
    public GetMinMaxSensorData(int deviceId)
    {
        var parameters = new SensorDataParameters(deviceId, FronApiUsConstants.DataCollection.SensorData.MinMax);
        Endpoint = new SensorDataEndpoint(parameters);
    }

    public IFronApiUsEndpoint<IFronApiUsParameters> Endpoint { get; }
}

public class GetMinMaxSensorDataHandler : IRequestHandler<GetMinMaxSensorData, List<MinMaxSensorData>>
{
    private readonly IFronApiUsClient _fronApiUsClient;

    public GetMinMaxSensorDataHandler(IFronApiUsClient fronApiUsClient)
    {
        _fronApiUsClient = fronApiUsClient;
    }

    public Task<List<MinMaxSensorData>> Handle(GetMinMaxSensorData request, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}