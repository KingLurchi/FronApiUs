namespace FronApiUs.Core.Models;

public class Status
{
    public int Code { get; set; }
    public string Reason { get; set; } = string.Empty;
    public string UserMessage { get; set; } = string.Empty;

    public string ExceptionMessage => $"Error Code {Code} - {Reason}{(string.IsNullOrWhiteSpace(UserMessage) ? "" : $" ({UserMessage})")}";
}