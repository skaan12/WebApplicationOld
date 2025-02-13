using MODEL.Entities.UserEntities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Abstracts
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync (string userId);
        Task<User> GetById(string id);

       
        IQueryable<User> GetPassive();
        IQueryable<User> GetMembers();
        IQueryable<User> GetAdmin();
        IQueryable<User> GetAll();
        IQueryable<User> GetBasicMembers();

        IQueryable<User> GetGoldMembers();

        IQueryable<User> GetPremiumMembers();
        
    }
}
