using MODEL.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstracts.UserAbstracts
{
    public interface IUserService
    {
        void CreateUser(User user);
        void UpdateUser(User user);
        User GetUserById(int id);
    }
}
