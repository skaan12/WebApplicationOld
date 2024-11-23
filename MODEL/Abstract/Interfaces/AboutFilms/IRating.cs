using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutFilms
{
    public interface IRating
    {
        public int FilmID { get; set; }

        public string UserID { get; set; }

        public double Score { get; set; }

        public string? Review { get; set; }

        public DateTime ReviewDate { get; set; }
    }
}
