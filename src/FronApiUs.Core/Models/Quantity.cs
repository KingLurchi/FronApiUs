namespace FronApiUs.Core.Models;

public class Quantity<T>
{
    public string Unit { get; set; } = string.Empty;
    public T Value { get; set; } = default!;
}

public class DeviceQuantity<T>
{
    public string Unit { get; set; } = string.Empty;
    public Dictionary<string, T> Values { get; set; } = new();
}