using MODEL.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutOrders
{
    public interface IDeliveriesEntity
    {




        public int CourierID { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public DeliveryStatus DeliveryStatus { get; set; }
    }
}
