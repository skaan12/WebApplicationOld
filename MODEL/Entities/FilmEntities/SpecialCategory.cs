using MODEL.Abstract.BaseEntities.Films;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.FilmEntities
{
    public class SpecialCategory:BaseSpecialCategoryEntity
    {
        public List<Film> Film {  get; set; }
    }
}
