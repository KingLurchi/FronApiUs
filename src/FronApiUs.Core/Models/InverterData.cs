using System.Text.Json.Serialization;

namespace FronApiUs.Core.Models;

public class InverterData : FronApiUsDevice
{
    public Quantity<int> PowerAc { get; set; } = new();
    public Quantity<int> EnergyToday { get; set; } = new();
    public Quantity<decimal> EnergyThisYear { get; set; } = new();
    public Quantity<long> EnergyOverall { get; set; } = new();
}


public class SystemInverterData : FronApiUsResponse<InverterDataContent>
{
}

public class InverterDataContent
{
    [JsonPropertyName("PAC")]
    public DeviceQuantity<int> PowerAc { get; set; } = new();

    [JsonPropertyName("DAY_ENERGY")]
    public DeviceQuantity<int> EnergyToday { get; set; } = new();

    [JsonPropertyName("YEAR_ENERGY")]
    public DeviceQuantity<decimal> EnergyThisYear { get; set; } = new();

    [JsonPropertyName("TOTAL_ENERGY")]
    public DeviceQuantity<long> EnergyOverall { get; set; } = new();
}