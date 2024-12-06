using MODEL.Abstract.Enums;
using MODEL.Abstract.Interfaces;
using MODEL.Abstract.Interfaces.AboutFilms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Users
{
    public abstract class BaseUserFilmListEntity : IUserFilmListEntity,IJoinEntity<string,int>
    {

        public string UserID { get; set; }
        public int FilmID { get; set; }
        public int Priority { get; set; }
        public DateTime Date { get; set; }
        public string FirstID { get => UserID; set => UserID = value ; }
        public int SecondID { get => FilmID; set => FilmID = value ; }
    }
}
