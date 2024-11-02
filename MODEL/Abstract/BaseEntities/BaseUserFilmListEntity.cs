using MODEL.Abstract.Enums;
using MODEL.Abstract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities
{
    public abstract class BaseUserFilmListEntity : IBaseEntity<string>,IUserFilmListEntity
    {
        
        public string UserID { get  ; set  ; }
        public int FilmID { get ; set  ; }
        public int Priority { get  ; set  ; }
        public DateTime Date { get  ; set  ; }
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
