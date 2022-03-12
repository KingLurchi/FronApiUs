using FronApiUs.Core.Models;

namespace FronApiUs.Core.Extensions;

public static class ModelExtensions
{
    public static Quantity<T> ExtractQuantity<T>(this DeviceQuantity<T> deviceQuantity, string key)
    {
        var quantity = new Quantity<T> { Unit = deviceQuantity.Unit };

        if (deviceQuantity.Values.ContainsKey(key) == false)
        {
            quantity.Value = default!;

            return quantity;
        }

        quantity.Value = deviceQuantity.Values[key];

        return quantity;
    }
}