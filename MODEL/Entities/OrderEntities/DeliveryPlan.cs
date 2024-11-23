using MODEL.Abstract.BaseEntities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.OrderEntities
{
    public class DeliveryPlan:BaseDeliveryPlanEntity
    {
        public Delivery Delivery {  get; set; }
    }
}
