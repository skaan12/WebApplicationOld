using MODEL.Abstract.Interfaces;
using MODEL.Abstract.Interfaces.AboutFilms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Films
{
    public abstract class BaseFilmDirector : IFilmDirector,IJoinEntity<int, int>
    {
        public int FilmID { get ; set ; }
        public int DirectorID { get ; set ; }
        public string? Role { get ; set ; }
        public int FirstID { get => FilmID; set => FilmID = value; }
        public int SecondID { get => DirectorID; set => DirectorID = value; }
    }
}
