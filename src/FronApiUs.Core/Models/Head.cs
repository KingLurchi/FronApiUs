namespace FronApiUs.Core.Models;

public class Head
{
    public RequestArguments RequestArguments { get; set; } = new();
    public Status Status { get; set; } = new();
    public DateTime Timestamp { get; set; }
}