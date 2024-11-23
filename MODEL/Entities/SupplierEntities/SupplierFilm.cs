using MODEL.Abstract.BaseEntities.Suppliers;
using MODEL.Entities.FilmEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.SupplierEntities
{
    public class SupplierFilm:BaseSupplierFilm
    {
        public Film Film { get; set; }

        public Supplier Supplier { get; set; }
    }
}
