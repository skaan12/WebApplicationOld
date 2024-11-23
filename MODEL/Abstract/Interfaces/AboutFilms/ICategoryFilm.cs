using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutFilms
{
    public interface ICategoryFilm
    {
        public int FilmID { get; set; }

        public int CategoryID { get; set; }
    }
}
