using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutFilms
{
    public interface IInventory
    {
        public int FilmID { get; set; }

        public int SupplierID { get; set; }

        public int?  StockCount {  get; set; }

        public int? DamagedCount { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}
