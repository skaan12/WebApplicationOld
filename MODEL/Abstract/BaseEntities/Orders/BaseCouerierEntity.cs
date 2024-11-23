using MODEL.Abstract.Interfaces.AboutOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Orders
{
    public abstract class BaseCouerierEntity : BaseEntity, ICourierEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

    }
}
