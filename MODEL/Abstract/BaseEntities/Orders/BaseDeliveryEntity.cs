using MODEL.Abstract.Enums;
using MODEL.Abstract.Interfaces.AboutOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Orders
{
    public abstract class BaseDeliveryEntity : BaseEntity, IDeliveriesEntity
    {


        public int CourierID { get; set; }


        public DateTime DeliveryDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }


    }
}
