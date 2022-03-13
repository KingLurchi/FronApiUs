using FronApiUs.Core.Contracts;
using FronApiUs.Core.Endpoints;
using FronApiUs.Core.Models;
using FronApiUs.Core.Parameters;
using MediatR;

namespace FronApiUs.Core.Requests;

public class GetSensorData : IFronApiUsRequest, IRequest<List<MinMaxSensorData>>
{
    public GetSensorData()
    {
        var parameters = new SensorDataParameters();
        Endpoint = new SensorDataEndpoint(parameters);
    }

    public IFronApiUsEndpoint<IFronApiUsParameters> Endpoint { get; }
}

public class GetSensorDataHandler : IRequestHandler<GetSensorData, List<MinMaxSensorData>>
{
    private readonly IFronApiUsClient _fronApiUsClient;

    public GetSensorDataHandler(IFronApiUsClient fronApiUsClient)
    {
        _fronApiUsClient = fronApiUsClient;
    }

    public Task<List<MinMaxSensorData>> Handle(GetSensorData request, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}