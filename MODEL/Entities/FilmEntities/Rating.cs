using MODEL.Abstract.BaseEntities.Films;
using MODEL.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.FilmEntities
{
    public class Rating:BaseRatingEntity
    {
        public Film Film { get; set; }

        public User User { get; set; }
    }
}
