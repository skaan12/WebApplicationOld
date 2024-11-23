using MODEL.Abstract.Enums;
using MODEL.Abstract.Interfaces.AboutSuppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Suppliers
{
    public abstract class BasePaymentEntity : BaseEntity, IPayment
    {
        public int SupplierID { get ; set ; }
        public decimal Amount { get ; set ; }
        public DateTime PaymentDate { get ; set ; }
        public string Description { get ; set ; }
        public PaymentMethod Method { get ; set ; }
        PaymentStatus IPayment.Status { get ; set ; }
    }
}
