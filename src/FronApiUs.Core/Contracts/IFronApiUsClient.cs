namespace FronApiUs.Core.Contracts;

public interface IFronApiUsClient
{
    Task<TResponse?> Get<TResponse>(IFronApiUsRequest request, CancellationToken token) where TResponse : IFronApiUsResponse;
}