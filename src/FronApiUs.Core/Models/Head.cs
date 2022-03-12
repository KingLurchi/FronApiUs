namespace FronApiUs.Core.Models
{
    public class Head
    {
        public RequestArguments RequestArguments { get; set; } = new RequestArguments();
        public Status Status { get; set; } = new Status();
        public DateTime Timestamp { get; set; }
    }
}