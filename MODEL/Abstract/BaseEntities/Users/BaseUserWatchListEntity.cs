using MODEL.Abstract.Interfaces.AboutUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Users
{
    public abstract class BaseUserWatchListEntity : IUserWatchList
    {
        public int FilmID { get ; set ; }
        public string UserID { get ; set ; }
        public string LastName { get ; set ; }
    }
}
