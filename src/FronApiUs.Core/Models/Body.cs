namespace FronApiUs.Core.Models;

public class Body<TData> where TData : class, new()
{
    public TData Data { get; set; } = new();
}