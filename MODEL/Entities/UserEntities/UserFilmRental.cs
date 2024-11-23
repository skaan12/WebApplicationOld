using MODEL.Abstract.BaseEntities.Users;
using MODEL.Entities.FilmEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.UserEntities
{
    public class UserFilmRental:BaseUserFilmRental
    {
        public Film Film { get; set; }

        public User User { get; set; }
    }
}
