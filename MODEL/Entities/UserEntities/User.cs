using MODEL.Abstract.BaseEntities.Users;
using MODEL.Entities.FilmEntities;
using MODEL.Entities.OrderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.UserEntities
{
    public class User : BaseUserEntity
    {
        //Relation
        public Membership Membership { get; set; }

        public List<Order> Order { get; set; }

        public List<UserFilmList> UserFilmList { get; set; }

        //Relation : Rating

        public List<Rating> Rating { get; set; }

        //Relation : Comment
        public List<Comment> Comment { get; set; }
        //Relation : Notification
        public List<Notification> Notification { get; set; }
        //Relation : UserWatchList
        public List<UserWatchList> UserWatchList { get; set; }

        //Relation : UserFilmRental
        public List<UserFilmRental> userFilmRentals { get; set; }
    }
}
