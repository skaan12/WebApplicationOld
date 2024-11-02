using MODEL.Abstract.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class Film:BaseFilmEntity
    {
        //Relation:Order Detail

        public List<OrderDetail> OrderDetails { get; set; }

        //Relation:Faulty Film

        public List<FaultyFilm> faultyFilms { get; set; }

        public List<UserFilmList> UserFilmList { get; set; }
    }
}
