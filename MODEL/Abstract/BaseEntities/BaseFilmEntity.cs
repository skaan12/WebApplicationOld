using MODEL.Abstract.Enums;
using MODEL.Abstract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities
{
    public abstract class BaseFilmEntity : IBaseEntity<string>,IFilmEntity
    {
        
        public string FilmName { get  ; set  ; }
        public string OriginalName { get  ; set  ; }
        public string Director { get  ; set  ; }
        public string Category { get  ; set  ; }
        public string Description { get  ; set  ; }
        public string Actors { get  ; set  ; }
        public DateTime Year { get  ; set  ; }
        public string Language { get  ; set  ; }
        public string Subtitles { get  ; set  ; }
        public string TrailerURL { get  ; set  ; }
        public string Awards { get  ; set  ; }
        public string Supplier { get  ; set  ; }
        public int StockInQuantity { get  ; set  ; }
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
