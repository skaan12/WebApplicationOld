using MODEL.Abstract.BaseEntities.Orders;
using MODEL.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.OrderEntities
{
    public class Order : BaseOrderEntity
    {
        //Relation

        public User User { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public Delivery Delivery { get; set; }
    }
}
