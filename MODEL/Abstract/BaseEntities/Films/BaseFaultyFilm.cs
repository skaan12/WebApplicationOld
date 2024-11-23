using MODEL.Abstract.Enums;
using MODEL.Abstract.Interfaces.AboutFilms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Films
{
    public abstract class BaseFaultyFilm : BaseEntity, IFaultyFilmEntity
    {

        public int FilmID { get; set; }
        public DateTime TestDate { get; set; }
        public FaultyFilmStatus? FilmStatus { get; set; }
        public int InventoryID { get; set; }

    }
}
