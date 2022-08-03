using FronApiUs.Core.Contracts;
using FronApiUs.Core.Models;

namespace FronApiUs.Core;

public class FronApiUsResponse<TData> : IFronApiUsResponse where TData : class, new()
{
    public Body<TData> Body { get; set; } = new();
    public Head Head { get; set; } = new();
}