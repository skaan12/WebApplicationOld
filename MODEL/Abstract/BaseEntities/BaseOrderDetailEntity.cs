using MODEL.Abstract.Enums;
using MODEL.Abstract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities
{
    public abstract class BaseOrderDetailEntity : IBaseEntity<string>, IOrderDetailEntity
    {
       
        public int OrderID { get  ; set  ; }
        public int FilmID { get  ; set  ; }
        public int ID { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public string ComputerName { get ; set ; }
        public string CreatedIpAdress { get ; set ; }
        public DateTime? UpdatedTime { get ; set ; }
        public string? UpdatedComputerName { get ; set ; }
        public string? UpdatedIpAdress { get ; set ; }
        public DataStatus Status { get ; set ; }
    }
}
