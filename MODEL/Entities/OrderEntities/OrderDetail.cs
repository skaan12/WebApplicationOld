using MODEL.Abstract.BaseEntities.Orders;
using MODEL.Entities.FilmEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.OrderEntities
{
    public class OrderDetail : BaseOrderDetailEntity
    {
        //Relation

        public Order Order { get; set; }

        public Film Film { get; set; }
    }
}
