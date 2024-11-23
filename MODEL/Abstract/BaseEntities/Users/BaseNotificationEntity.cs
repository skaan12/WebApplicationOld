using MODEL.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Users
{
    public abstract class BaseNotificationEntity : BaseEntity, INotification
    {
        public string UserID { get ; set ; }
        public string Message { get ; set ; }
        public bool? IsRead { get ; set ; }
        public DateTime NotificationDate { get ; set ; }
        public NotificationType NotificationType { get ; set ; }
    }
}
