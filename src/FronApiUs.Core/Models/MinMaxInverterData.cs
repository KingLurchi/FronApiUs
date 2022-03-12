using System.Text.Json.Serialization;

namespace FronApiUs.Core.Models;

public class MinMaxInverterData : FronApiUsResponse<MinMaxInverterDataContent>
{
}

public class MinMaxInverterDataContent
{
    [JsonPropertyName("DAY_PMAX")]
    public Quantity<int> MaximumACPowerCurrentDay { get; set; } = new();

    [JsonPropertyName("DAY_UACMAX")]
    public Quantity<decimal> MaximumACVoltageCurrentDay { get; set; } = new();

    [JsonPropertyName("DAY_UACMIN")]
    public Quantity<decimal> MinimumACVoltageCurrentDay { get; set; } = new();

    [JsonPropertyName("DAY_UDCMAX")]
    public Quantity<decimal> MaximumDCPowerCurrentDay { get; set; } = new();

    [JsonPropertyName("YEAR_PMAX")]
    public Quantity<int> MaximumACPowerCurrentYear { get; set; } = new();

    [JsonPropertyName("YEAR_UACMAX")]
    public Quantity<decimal> MaximumACVoltageCurrentYear { get; set; } = new();

    [JsonPropertyName("YEAR_UACMIN")]
    public Quantity<decimal> MinimumACVoltageCurrentYear { get; set; } = new();

    [JsonPropertyName("YEAR_UDCMAX")]
    public Quantity<decimal> MaximumDCPowerCurrentYear { get; set; } = new();

    [JsonPropertyName("TOTAL_PMAX")]
    public Quantity<int> MaximumACPowerCurrentOverall { get; set; } = new();

    [JsonPropertyName("TOTAL_UACMAX")]
    public Quantity<decimal> MaximumACVoltageCurrentOverall { get; set; } = new();

    [JsonPropertyName("TOTAL_UACMIN")]
    public Quantity<decimal> MinimumACVoltageCurrentOverall { get; set; } = new();

    [JsonPropertyName("TOTAL_UDCMAX")]
    public Quantity<decimal> MaximumDCPowerCurrentOverall { get; set; } = new();
}