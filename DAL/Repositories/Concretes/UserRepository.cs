using DAL.Context;
using DAL.Repositories.Abstracts;
using MODEL.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.Abstract.Enums;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Concretes
{
    public class UserRepository : IUserRepository
    {
        private readonly ProjectContext _context;

        public UserRepository(ProjectContext context)
        {
            _context = context;
        }
        public async Task AddAsync(User user)
        {
           await _context.Users.AddAsync(user);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string userId)
        {
            var existingUser = await _context.Users.FindAsync(userId);
            if ( existingUser != null) 
            {
                existingUser.DataStatus = DataStatus.Inactive;
                existingUser.UpdatedTime = DateTime.Now;
                _context.Users.Update(existingUser);
                await _context.SaveChangesAsync();

            }
        }
        public async Task UpdateAsync(User user)
        {
            user.UpdatedTime = DateTime.Now;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public IQueryable<User> GetAdmin()
        {
            return _context.Users.Where(a=>a.UserType == UserType.Admin);
        }

        public IQueryable<User> GetAll()
        {
            return _context.Users.Where(u=>u.DataStatus == DataStatus.Active && u.DataStatus == DataStatus.Inactive && u.UserType == UserType.Member);
        }
        public async Task<User> GetById(string id)
        {
            return await _context.Users.FindAsync(id);
        }

        public IQueryable<User> GetBasicMembers()
        {
            return _context.Users.Where(b => b.UserType == UserType.Member && b.MembershipType == MembershipType.Basic);
        }               
        public IQueryable<User> GetGoldMembers()
        {
            return _context.Users.Where(g=>g.UserType == UserType.Member && g.MembershipType == MembershipType.Gold);
        }
        public IQueryable<User> GetPremiumMembers()
        {
            return _context.Users.Where(p=>p.UserType == UserType.Member && p.MembershipType == MembershipType.Premium);
        }

        public IQueryable<User> GetMembers()
        {
            return _context.Users.Where(m=>m.MembershipStatus== MembershipStatus.Active);
        }

        public IQueryable<User> GetPassive()
        {
            return _context.Users.Where(p=>p.UserType == UserType.Member && p.DataStatus == DataStatus.Inactive );
        }            
        

        
    }
}
