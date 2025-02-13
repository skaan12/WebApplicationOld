using BLL.Services.Abstracts.UserAbstracts;
using DAL.Repositories.Abstracts;
using Microsoft.AspNetCore.Identity;
using MODEL.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Runtime.InteropServices;

namespace BLL.Services.Concretes.UserConcretes
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly IEncryptionService _encryptionService;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserService(IUserRepository userRepository, IPasswordHasher<User> passwordHasher, IEncryptionService encryptionService,UserManager<User> userManager,RoleManager<IdentityRole> roleManager)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _encryptionService = encryptionService;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        
        public async Task CreateUserAsync(User user,string password,string cvc,string creditCard)
        {
            //Kullanıcıya ait parolayı hashliyoruz. The user's password is hashed.
            user.PasswordHash = _passwordHasher.HashPassword(user, password);
            //Kredi kartı bilgilerini şifreliyoruz.
            user.CreditCardNumber = _encryptionService.Encrypt(creditCard);
            user.CVC = _encryptionService.Encrypt(cvc);
            var result = await _userManager.CreateAsync(user);
            if (!result.Succeeded) 
            {
                throw new Exception("Kullanıcı oluşturulamadı");
            }
                        
        }
        public async Task AssignRoleToUserAsync(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) 
            {
                throw new Exception("Kullanıcı bulunamadı");
            }
            var roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName));
            }
            await _userManager.AddToRoleAsync(user, roleName);
        }
        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateAsync(user);
        }
        public Task<User> GetUserByIdAsync(string id)
        {
            var user = _userRepository.GetById(id);
            return user;

        }

        public async Task DeleteUserAsync(string userId)
        {
            await _userRepository.DeleteAsync(userId);
        }

        public IEnumerable<User> GetAdmins()
        {
           return _userRepository.GetAdmin().ToList();
        }

        public  IEnumerable<User> GetAllUsers()
        {
            return  _userRepository.GetAll().ToList();
        }

        public IEnumerable<User> GetBasicMembers()
        {
            return _userRepository.GetBasicMembers().ToList();
        }

        public IEnumerable<User> GetGoldMembers()
        {
           return _userRepository.GetGoldMembers().ToList();
        }

        public IEnumerable<User> GetMembers()
        {
            return _userRepository.GetMembers().ToList();
        }

        public IEnumerable<User> GetPassiveMembers()
        {
            return _userRepository.GetPassive().ToList();
        }

        public IEnumerable<User> GetPremiumMembers()
        {
            return _userRepository.GetPremiumMembers().ToList();
        }

        
    }
}