using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutFilms
{
    public interface IFilmArtist
    {
        public int FilmID { get; set; }

        public int ArtistID { get; set; }

        public string? Role { get; set; }
    }
}
