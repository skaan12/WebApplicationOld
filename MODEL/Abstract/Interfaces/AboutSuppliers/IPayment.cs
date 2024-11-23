using MODEL.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutSuppliers
{
    public interface IPayment
    {
        public int SupplierID { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; } // Ödeme tarihi
        public string Description { get; set; } // Ödemenin açıklaması
        public PaymentMethod Method { get; set; } // Ödeme yöntemi (enum)
        public PaymentStatus Status { get; set; }
    }
}
