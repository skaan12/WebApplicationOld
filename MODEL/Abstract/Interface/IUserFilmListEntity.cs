using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interface
{
    public interface IUserFilmListEntity
    {
        //public int ListID { get; set; }

        public string UserID { get; set; }

        public int FilmID { get; set; }

        public int Priority { get; set; }

        public DateTime Date { get; set; }
    }
}
