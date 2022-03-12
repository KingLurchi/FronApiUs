using System.Text.Json;
using FronApiUs.Core.Contracts;

namespace FronApiUs.Core;

public interface IFronApiUsClient
{
    Task<TResponse?> Get<TResponse>(IFronApiUsRequest request, CancellationToken token) where TResponse : IFronApiUsResponse;
}

public class FronApiUsClient : IFronApiUsClient
{
    private readonly HttpClient _client;

    public FronApiUsClient(IFronApiUsConfiguration configuration, HttpClient client)
    {
        _client = client;
        _client.BaseAddress = configuration.BaseAddress;
    }

    public async Task<TResponse?> Get<TResponse>(IFronApiUsRequest request, CancellationToken token) where TResponse : IFronApiUsResponse
    {
        using var response = await _client.SendAsync(request.Endpoint.RequestMessage, HttpCompletionOption.ResponseHeadersRead, token).ConfigureAwait(false);
        await using var stream = await response.Content.ReadAsStreamAsync(token);
        if (response.IsSuccessStatusCode == false)
            return default; // TODO: handle non device specific errors

        var result = await JsonSerializer.DeserializeAsync<TResponse?>(stream, new JsonSerializerOptions(JsonSerializerDefaults.General), token);
        if (result == null)
            return default;

        if (result.Head.Status.Code != 0)
            throw new FronApiUsException(result.Head.Status);

        return result;
    }
}