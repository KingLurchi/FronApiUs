using System.Text.Json.Serialization;

namespace FronApiUs.Core.Models;

public class CommonInverterData : FronApiUsResponse<CommonInverterDataContent>
{
}

public class CommonInverterDataContent
{
    [JsonPropertyName("PAC")]
    public Quantity<int> PowerAC { get; set; } = new();

    [JsonPropertyName("IAC")]
    public Quantity<decimal> CurrentAC { get; set; } = new();

    [JsonPropertyName("UAC")]
    public Quantity<decimal> VoltageAC { get; set; } = new();
    
    [JsonPropertyName("FAC")]
    public Quantity<decimal> FrequencyAC { get; set; } = new();
    
    [JsonPropertyName("IDC")]
    public Quantity<decimal> CurrentDC { get; set; } = new();
    
    [JsonPropertyName("UDC")]
    public Quantity<decimal> VoltageDC { get; set; } = new();

    [JsonPropertyName("DAY_ENERGY")]
    public Quantity<decimal> EnergyToday { get; set; } = new();

    [JsonPropertyName("YEAR_ENERGY")]
    public Quantity<decimal> EnergyThisYear { get; set; } = new();

    [JsonPropertyName("TOTAL_ENERGY")]
    public Quantity<long> EnergyOverall { get; set; } = new();

    public DeviceStatus DeviceStatus { get; set; } = new();
}