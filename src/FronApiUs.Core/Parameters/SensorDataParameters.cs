using FronApiUs.Core.Contracts;

namespace FronApiUs.Core.Parameters;

public class SensorDataParameters : IFronApiUsParameters
{
    public SensorDataParameters()
    {
        Scope = FronApiUsConstants.Scope.System;
    }

    public SensorDataParameters(int deviceId, string dataCollection)
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