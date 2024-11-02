using MODEL.Abstract.Enums;
using MODEL.Abstract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities
{
    public abstract class BaseMembershipEntity : IBaseEntity<string>, IMembershipEntity
    {
        
        public string PackageName { get  ; set  ; }
        public decimal MontlyFee { get  ; set  ; }
        public int FilmLimit { get  ; set  ; }
        public int FilmPerExchange { get  ; set  ; }
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
