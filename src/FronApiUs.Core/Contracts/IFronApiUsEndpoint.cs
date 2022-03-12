using System.Text;
using System.Text.Json;
using FronApiUs.Core.Extensions;
using Microsoft.AspNetCore.WebUtilities;

namespace FronApiUs.Core.Contracts;

public interface IFronApiUsEndpoint<out TParameters> where TParameters : IFronApiUsParameters
{
    string ApiVersion { get; }
    HttpMethod Method { get; }
    string Route { get; }
    TParameters Parameters { get; }
    object? Content { get; }

    HttpRequestMessage RequestMessage
    {
        get
        {
            var queryString = QueryHelpers.AddQueryString($"solar_api/{ApiVersion}/{Route}.cgi", Parameters.ToQueryString());
            var message = new HttpRequestMessage(Method, queryString);
            if (Content == null)
                return message;

            message.Content = new StringContent(JsonSerializer.Serialize(Content), Encoding.UTF8, "application/json");

            return message;
        }
    }
}