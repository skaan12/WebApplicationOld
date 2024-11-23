using BLL.Services.Abstracts;
using DAL.Repositories.Abstracts;
using MODEL.Entities.FilmEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Concretes
{
    public class UserFilmListService : Service<UserFilmList>,IUserFilmListService
    {
        public UserFilmListService(IRepository<UserFilmList> repository) : base(repository)
        {
        }
    }
}
