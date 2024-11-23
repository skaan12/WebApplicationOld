using MODEL.Abstract.Interfaces.AboutSuppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Suppliers
{
    public abstract class BaseSupplierFilm : ISupplierFilm
    {
        public int SupplierID { get ; set ; }
        public int FilmID { get ; set ; }
        public DateTime SuppliedDate { get ; set ; }
        public int Quantity { get ; set ; }
    }
}
