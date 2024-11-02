using MODEL.Abstract.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class User:BaseUserEntity
    {
        //Relation
        public Membership Membership { get; set; }

        public List<Order> Order { get; set; }

        public List<UserFilmList> UserFilmList { get; set; }
    }
}
