using MODEL.Entities.FilmEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutFilms
{
    public interface IAward
    {
        public int FilmID { get; set; }

        public string AwardName { get; set; }

        public string? Category { get; set; }

        public string? WinnerName { get; set; }

        public DateTime AwardDate { get; set; }
    }
}
