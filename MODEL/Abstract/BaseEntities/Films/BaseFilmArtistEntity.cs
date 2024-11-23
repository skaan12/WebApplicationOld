using MODEL.Abstract.Interfaces.AboutFilms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Films
{
    public abstract class BaseFilmArtistEntity : IFilmArtist
    {
        public int FilmID { get ; set ; }
        public int ArtistID { get ; set ; }
        public string? Role { get ; set ; }
    }
}
