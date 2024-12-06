using MODEL.Abstract.Interfaces;
using MODEL.Abstract.Interfaces.AboutFilms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Films
{
    public abstract class BaseCategoryFilmEntity : ICategoryFilm,IJoinEntity<int,int>
    {
        public int FilmID { get ; set ; }
        public int CategoryID { get ; set ; }
        public int FirstID { get => FilmID; set => FilmID = value ; }
        public int SecondID { get =>CategoryID ; set => CategoryID = value ; }
    }
}
