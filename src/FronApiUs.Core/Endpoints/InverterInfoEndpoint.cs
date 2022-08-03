using FronApiUs.Core.Contracts;

namespace FronApiUs.Core.Endpoints;

public class InverterInfoEndpoint : IFronApiUsEndpoint<IFronApiUsParameters>
{
    public string ApiVersion => "v1";
    public HttpMethod Method => HttpMethod.Get;
    public string Route => "GetInverterInfo";
    public IFronApiUsParameters Parameters => FronApiUsParameters.Empty();
    public object? Content => null;
}