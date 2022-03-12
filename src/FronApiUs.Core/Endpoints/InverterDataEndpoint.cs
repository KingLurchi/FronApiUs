using FronApiUs.Core.Contracts;

namespace FronApiUs.Core.Endpoints;

public class InverterDataEndpoint : IFronApiUsEndpoint<IFronApiUsParameters>
{
    public InverterDataEndpoint(IFronApiUsParameters parameters)
    {
        Parameters = parameters;
    }

    public string ApiVersion => "v1";
    public HttpMethod Method => HttpMethod.Get;
    public string Route => "GetInverterRealtimeData";
    public IFronApiUsParameters Parameters { get; }
    public object? Content => null;
}