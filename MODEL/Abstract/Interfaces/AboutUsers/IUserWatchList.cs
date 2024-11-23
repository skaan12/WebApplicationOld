using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutUsers
{
    public interface IUserWatchList
    {
        public int FilmID { get; set; }

        public string UserID { get; set; }

        public string LastName { get; set; }
    }
}
