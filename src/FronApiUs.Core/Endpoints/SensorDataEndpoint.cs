using FronApiUs.Core.Contracts;

namespace FronApiUs.Core.Endpoints;

public class SensorDataEndpoint : IFronApiUsEndpoint<IFronApiUsParameters>
{
    public SensorDataEndpoint(IFronApiUsParameters parameters)
    {
        Parameters = parameters;
    }

    public string ApiVersion => "v1";
    public HttpMethod Method => HttpMethod.Get;
    public string Route => "GetSensorRealtimeData";
    public IFronApiUsParameters Parameters { get; }
    public object? Content => null;
}