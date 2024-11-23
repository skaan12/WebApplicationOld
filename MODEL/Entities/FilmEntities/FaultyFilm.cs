using MODEL.Abstract.BaseEntities.Films;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.FilmEntities
{
    public class FaultyFilm : BaseFaultyFilm
    {
        public Film Film { get; set; }

        public Inventory Inventory { get; set; }
    }
}
