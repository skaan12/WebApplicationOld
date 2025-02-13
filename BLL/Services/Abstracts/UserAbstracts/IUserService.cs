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
        Task CreateUserAsync(User user,string password, string cvc, string creditCard);
        Task UpdateUserAsync(User user);        
        Task AssignRoleToUserAsync(string userId,string roleName);
        Task DeleteUserAsync(string userId);
        Task<User> GetUserByIdAsync(string id);

        IEnumerable<User> GetAllUsers();
        IEnumerable<User> GetAdmins();
        IEnumerable<User> GetMembers();
        IEnumerable<User> GetPassiveMembers();

        IEnumerable<User> GetBasicMembers();

        IEnumerable<User> GetGoldMembers();

        IEnumerable<User> GetPremiumMembers();


    }
}
