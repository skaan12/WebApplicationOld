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
    public abstract class BaseUserFilmListEntity : BaseEntity, IUserFilmListEntity
    {

        public string UserID { get; set; }
        public int FilmID { get; set; }
        public int Priority { get; set; }
        public DateTime Date { get; set; }


    }
}
