using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using FronApiUs.Core;
using FronApiUs.Core.Contracts;

namespace FronApiUs.Tests;

public class MockFronApiUsClient : IFronApiUsClient
{
    public async Task<TResponse?> Get<TResponse>(IFronApiUsRequest request, CancellationToken token) where TResponse : IFronApiUsResponse
    {
        var fileName = $@"{CleanFileName(request.Endpoint.QueryString)}.json";
        var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", fileName);

        await using var stream = File.OpenRead(path);
        var result = await JsonSerializer.DeserializeAsync<TResponse?>(stream, new JsonSerializerOptions(JsonSerializerDefaults.General), token);
        if (result == null)
            return default;

        if (result.Head.Status.Code != 0)
            throw new FronApiUsException(result.Head.Status);

        return result;
    }

    private string CleanFileName(string queryString)
    {
        return queryString.Replace("?", "%").Replace("&", "+").Replace("/", "-").Replace(".", "-");
    }
}