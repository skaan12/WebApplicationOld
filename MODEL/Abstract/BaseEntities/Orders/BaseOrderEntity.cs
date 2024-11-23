using MODEL.Abstract.Enums;
using MODEL.Abstract.Interfaces.AboutOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Orders
{
    public abstract class BaseOrderEntity : BaseEntity, IOrderEntity
    {
        public int DeliveryID { get; set; }

        public string UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DeliveryStatus Status { get; set; }

    }
}
