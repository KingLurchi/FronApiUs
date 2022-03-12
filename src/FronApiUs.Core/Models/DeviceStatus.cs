using System.Text.Json.Serialization;

namespace FronApiUs.Core.Models;

public class DeviceStatus
{
    public int ErrorCode { get; set; }

    [JsonPropertyName("MgmtTimerRemainingTime")]
    public int RemainingManagementTime { get; set; }

    [JsonPropertyName("LEDColor")]
    public int LedColor { get; set; }

    [JsonPropertyName("LEDState")]
    public int LedState { get; set; }

    public bool StateToReset { get; set; }
    public int StatusCode { get; set; }

}