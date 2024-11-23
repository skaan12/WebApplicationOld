using MODEL.Abstract.BaseEntities.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.SupplierEntities
{
    public class Payment:BasePaymentEntity
    {
        public Supplier Supplier { get; set; }
    }
}
