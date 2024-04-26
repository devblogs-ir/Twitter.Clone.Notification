using Microsoft.AspNetCore.Authentication;
using Twitter.Clone.Notification.Common;

namespace Twitter.Clone.Notification.Model
{
    public class NotificationLog:EntityBase
    {
        public EventType EventType{ get; set; }
        public string EventBody { get; set; }
        public EventState EventState { get; set; }
    }
}
