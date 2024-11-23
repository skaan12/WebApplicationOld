using MODEL.Abstract.Enums;
using MODEL.Abstract.Interfaces.AboutOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Orders
{
    public abstract class BaseDeliveryPlanEntity : BaseEntity, IDeliveryPlan
    {
        public int DeliveryID { get ; set ; }
        public DateTime PlannedDate { get ; set ; }
        public DateTime? ActualDeliveryDate { get ; set ; }
        public DeliveryStatus DeliveryStatus { get ; set ; }
        public string? Notes { get ; set ; }
    }
}
