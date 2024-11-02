using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interface
{
    public interface IMembershipEntity
    {
        //public int MembershipID { get; set; }

        public string PackageName { get; set; }

        public decimal MontlyFee { get; set; }

        public int FilmLimit { get; set; }

        public int FilmPerExchange { get; set; }
        //
    }
}
