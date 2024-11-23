using MODEL.Abstract.Interfaces.AboutUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Users
{
    public abstract class BaseUserFilmRental : IUserFilmRental
    {
        public string UserID { get ; set ; }
        public int FilmID { get ; set ; }
        public DateTime RentalDate { get ; set ; }
        public DateTime ReturnDate { get ; set ; }
        public decimal RentalPrice { get ; set ; }
        public bool IsReturned { get ; set ; }
    }
}
