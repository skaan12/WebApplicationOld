using MODEL.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interface
{
    public interface IFaultyFilmEntity
    {
        //public int FaultyFilmID { get; set; }

        public int FilmID { get; set; } 

        public DateTime TestDate { get; set; }

        public FaultyFilmStatus FilmStatus { get; set; }
    }
}
