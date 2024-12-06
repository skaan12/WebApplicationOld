using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutFilms
{
    public interface IFilmEntity
    {
        //public int ID { get; set; }

        public string FilmName { get; set; }

        public string OriginalName { get; set; }

        public string Director { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string Actors { get; set; }

        public DateTime Year { get; set; }

        public string Language { get; set; }

        public string Subtitles { get; set; }

        public string TrailerURL { get; set; }

        public string Awards { get; set; }

        public string Supplier { get; set; }

        public int StockInQuantity { get; set; }

        public int? SpecialCategoryID { get; set; }



    }
}
