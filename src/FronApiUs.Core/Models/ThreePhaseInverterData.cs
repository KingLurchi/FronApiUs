using System.Text.Json.Serialization;

namespace FronApiUs.Core.Models;

public class ThreePhaseInverterData : FronApiUsResponse<ThreePhaseInverterDataContent>
{
}

public class ThreePhaseInverterDataContent
{
    [JsonPropertyName("IAC_L1")]
    public Quantity<decimal> CurrentPhaseAC1 { get; set; } = new();

    [JsonPropertyName("IAC_L2")]
    public Quantity<decimal> CurrentPhaseAC2 { get; set; } = new();

    [JsonPropertyName("IAC_L3")]
    public Quantity<decimal> CurrentPhaseAC3 { get; set; } = new();

    [JsonPropertyName("UAC_L1")]
    public Quantity<decimal> VoltagePhaseAC1 { get; set; } = new();

    [JsonPropertyName("UAC_L2")]
    public Quantity<decimal> VoltagePhaseAC2 { get; set; } = new();

    [JsonPropertyName("UAC_L3")]
    public Quantity<decimal> VoltagePhaseAC3 { get; set; } = new();

    [JsonPropertyName("T_AMBIENT")]
    public Quantity<int> AmbientTemperature { get; set; } = new();

    [JsonPropertyName("ROTATION_SPEED_FAN_FL")]
    public Quantity<int> FanSpeedFrontLeft { get; set; } = new();

    [JsonPropertyName("ROTATION_SPEED_FAN_FR")]
    public Quantity<int> FanSpeedFrontRight { get; set; } = new();

    [JsonPropertyName("ROTATION_SPEED_FAN_BL")]
    public Quantity<int> FanSpeedBackLeft { get; set; } = new();

    [JsonPropertyName("ROTATION_SPEED_FAN_BR")]
    public Quantity<int> FanSpeedBackRight { get; set; } = new();
}