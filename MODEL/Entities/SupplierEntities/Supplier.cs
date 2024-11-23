using MODEL.Abstract.BaseEntities.Suppliers;
using MODEL.Entities.FilmEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.SupplierEntities
{
    public class Supplier:BaseSupplierEntity
    {
        public List<SupplierFilm> supplierFilms { get; set; }

        public List<Payment> payments { get; set; }

        public List<Inventory> Inventories { get; set; }
    }
}
