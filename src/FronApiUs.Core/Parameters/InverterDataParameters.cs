using FronApiUs.Core.Contracts;

namespace FronApiUs.Core.Parameters;

public class InverterDataParameters : IFronApiUsParameters
{
    public InverterDataParameters()
    {
        Scope = FronApiUsConstants.Scope.System;
    }

    public InverterDataParameters(int deviceId, string dataCollection)
    {
        if (deviceId is < 0 or > 99)
            throw new ArgumentOutOfRangeException(nameof(deviceId));

        DeviceId = deviceId;
        DataCollection = dataCollection;
        Scope = FronApiUsConstants.Scope.Device;
    }

    public string? DataCollection { get; }
    public int? DeviceId { get; }
    public string Scope { get; }
}