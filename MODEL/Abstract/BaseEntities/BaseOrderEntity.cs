using MODEL.Abstract.Enums;
using MODEL.Abstract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities
{
    public abstract class BaseOrderEntity : IBaseEntity<string>, IOrderEntity
    {
        
        //public int UserID { get  ; set  ; }
        public int DeliveryID { get; set; }
        public DateTime OrderDate { get  ; set  ; }
        public DateTime DeliveryDate { get  ; set  ; }
        public DeliveryStatus Status { get  ; set  ; }
        public int ID { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public string ComputerName { get ; set ; }
        public string CreatedIpAdress { get ; set ; }
        public DateTime? UpdatedTime { get ; set ; }
        public string? UpdatedComputerName { get ; set ; }
        public string? UpdatedIpAdress { get ; set ; }
        DataStatus IBaseEntity<string>.Status { get ; set ; }
    }
}
