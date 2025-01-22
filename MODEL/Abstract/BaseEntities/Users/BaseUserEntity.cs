
using Microsoft.AspNetCore.Identity;
using MODEL.Abstract.Enums;
using MODEL.Abstract.Interfaces.AboutUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Users
{
    public abstract class BaseUserEntity : IdentityUser, IUserEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string CreditCardNumber { get; set; }
        public DateTime CreditCardExpDate { get; set; }
        public string CVC { get; set; }

        public int MembershipID { get; set; }
        public DateTime MembershipDate { get; set; }
        public MembershipStatus MembershipStatus { get; set; }
        public UserType UserType { get ; set ; }
    }
}
