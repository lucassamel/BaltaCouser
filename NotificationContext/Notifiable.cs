using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaCourse.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }
        public bool IsInvalid => Notifications.Any();

        protected Notifiable()
        {
            Notifications = [];
        }

        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }
        public void AddRangeNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }
    }
}
