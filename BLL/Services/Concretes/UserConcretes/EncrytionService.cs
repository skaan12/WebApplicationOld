using BLL.Services.Abstracts.UserAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Concretes.UserConcretes
{
    public class EncrytionService : IEncryptionService
    {
        public string Encrypt(string plainText)
        {
            byte[] data = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(data);
        }


        public string Decrypt(string cipherText)
        {
            byte[] data = Convert.FromBase64String(cipherText);
            return Encoding.UTF8.GetString(data);
        }


    }
}
