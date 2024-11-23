using MODEL.Abstract.BaseEntities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.OrderEntities
{
    public class Delivery : BaseDeliveryEntity
    {
        public List<Order> Orders { get; set; }
        public Courier Courier { get; set; }

        public List<DeliveryPlan> DeliveryPlans { get; set; }
    }
}
