using MODEL.Abstract.BaseEntities.Films;
using MODEL.Entities.SupplierEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.FilmEntities
{
    public class Inventory:BaseInventoryEntity
    {
        //Relation Film
        public Film Film { get; set; }

        public List<FaultyFilm> FaultyFilm { get; set; }

        public Supplier Supplier { get; set; }
    }
}
