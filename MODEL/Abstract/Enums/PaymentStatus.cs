using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Enums
{
    public enum PaymentStatus
    {
        Pending,    // Beklemede
        Completed,  // Tamamlandı
        Failed,     // Başarısız
        Refunded    // İade edildi
    }
}
