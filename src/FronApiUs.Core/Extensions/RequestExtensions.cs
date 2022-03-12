using System.Reflection;
using FronApiUs.Core.Contracts;

namespace FronApiUs.Core.Extensions;

internal static class RequestExtensions
{
    public static IDictionary<string, string?> ToQueryString(this IFronApiUsParameters parameters)
    {
        var queryString = new Dictionary<string, string?>();

        var type = parameters.GetType();

        foreach (var propertyInfo in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            var value = propertyInfo.GetValue(parameters);
            if (value == null)
                continue;

            queryString.Add(propertyInfo.Name, value.ToString());
        }

        return queryString;
    }
}