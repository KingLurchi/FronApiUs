namespace FronApiUs.Core.Contracts;

public interface IFronApiUsRequest
{
    IFronApiUsEndpoint<IFronApiUsParameters> Endpoint { get; }
}