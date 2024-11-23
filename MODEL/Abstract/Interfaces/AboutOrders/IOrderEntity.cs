using MODEL.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutOrders
{
    public interface IOrderEntity
    {
        //public int OrderID { get; set; }

        //public int UserID { get; set; }

        public int DeliveryID { get; set; }


        public string UserID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DeliveryStatus Status { get; set; }
    }
}
