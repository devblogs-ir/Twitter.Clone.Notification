using Microsoft.AspNetCore.Authentication;

namespace Twitter.Clone.Notification.Model
{
    public class EntityBase
    {
        public long Id { get; set; }
        public  DateTime DateCreated { get; set; }
        //public DateTime DateModified { get; set; }
        //public Guid UserCreated { get; set; }
        //public Guid UserModified { get; set; }
    }
}
