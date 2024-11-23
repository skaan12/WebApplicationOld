using MODEL.Abstract.BaseEntities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.UserEntities
{
    public class Membership : BaseMembershipEntity
    {
        //Relation
        public List<User> User { get; set; }
    }
}
