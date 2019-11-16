namespace Gumby.Event.Models
{
    public class BelayOnEvent : IEvent
    {
        public string Topic { get => "BelayOn"; }
        public string Message { get => "BelayOn"; }
    }
}
