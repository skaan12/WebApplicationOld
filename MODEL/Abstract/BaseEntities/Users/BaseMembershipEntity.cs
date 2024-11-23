using MODEL.Abstract.Enums;
using MODEL.Abstract.Interfaces.AboutUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Users
{
    public abstract class BaseMembershipEntity : BaseEntity, IMembershipEntity
    {

        public string PackageName { get; set; }
        public decimal MontlyFee { get; set; }
        public int FilmLimit { get; set; }
        public int FilmPerExchange { get; set; }

    }
}
