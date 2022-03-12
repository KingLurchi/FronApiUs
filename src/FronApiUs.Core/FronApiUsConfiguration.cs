using System.Net;

namespace FronApiUs.Core;

public interface IFronApiUsConfiguration
{
    Uri BaseAddress { get; }
}

public class FronApiUsConfiguration : IFronApiUsConfiguration
{
    public FronApiUsConfiguration(IPAddress address)
    {
        if (address == null)
            throw new ArgumentNullException(nameof(address));

        BaseAddress = new Uri($"http://{address}/");
    }

    public FronApiUsConfiguration(Uri baseUrl)
    {
        BaseAddress = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));
    }

    public Uri BaseAddress { get; }
}