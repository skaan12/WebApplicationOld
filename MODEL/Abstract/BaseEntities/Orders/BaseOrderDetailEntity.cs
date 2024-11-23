using MODEL.Abstract.Enums;
using MODEL.Abstract.Interfaces.AboutOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Orders
{
    public abstract class BaseOrderDetailEntity : BaseEntity, IOrderDetailEntity
    {

        public int OrderID { get; set; }
        public int FilmID { get; set; }


    }
}
