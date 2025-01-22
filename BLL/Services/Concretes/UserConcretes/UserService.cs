using BLL.Services.Abstracts.UserAbstracts;
using Microsoft.AspNetCore.Identity;
using MODEL.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Concretes.UserConcretes
{
    public class UserService : IUserService
    {
        private readonly IEncryptionService _encryptionService;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserService(IEncryptionService encryptionService,IPasswordHasher<User> passwordHasher)
        {
            _encryptionService = encryptionService;
            _passwordHasher = passwordHasher;
        }

        public IPasswordHasher<User> PasswordHasher { get; }

        public void CreateUser(User user)
        {
            //Password hash
            user.PasswordHash = _passwordHasher.HashPassword(user, user.PasswordHash);
            user.CreditCardNumber = _encryptionService.Encrypt(user.CreditCardNumber);
            user.CVC = _encryptionService.Encrypt(user.CVC);
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            if (!string.IsNullOrEmpty(user.PasswordHash)) 
            {
                user.PasswordHash = _passwordHasher.HashPassword(user,user.PasswordHash);
            }
            user.CreditCardNumber = _encryptionService.Encrypt(user.CreditCardNumber);
            user.CVC = _encryptionService.Encrypt(user.CVC);
        }
    }
}
