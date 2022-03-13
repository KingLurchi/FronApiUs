using System.Text.Json.Serialization;

namespace FronApiUs.Core.Models;

public class CumulationInverterData : FronApiUsResponse<CumulationInverterDataContent>
{
}

public class CumulationInverterDataContent
{
    [JsonPropertyName("PAC")]
    public Quantity<int> PowerAc { get; set; } = new();

    [JsonPropertyName("DAY_ENERGY")]
    public Quantity<decimal> EnergyToday { get; set; } = new();
    
    [JsonPropertyName("YEAR_ENERGY")]
    public Quantity<decimal> EnergyThisYear { get; set; } = new();
    
    [JsonPropertyName("TOTAL_ENERGY")]
    public Quantity<long> EnergyOverall { get; set; } = new();

    public DeviceStatus DeviceStatus { get; set; } = new();
}