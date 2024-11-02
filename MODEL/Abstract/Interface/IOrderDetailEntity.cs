using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interface
{
    public interface IOrderDetailEntity
    {
        //public int OrderDetailID { get; set; }

        public int OrderID { get; set; }

        public int FilmID { get; set; }
    }
}
