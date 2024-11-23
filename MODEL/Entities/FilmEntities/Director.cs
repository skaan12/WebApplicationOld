using MODEL.Abstract.BaseEntities.Films;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities.FilmEntities
{
    public class Director:BaseDirectorEntity
    {
        //Relation : Film Director
        public List<FilmDirector> filmDirectors {  get; set; }
    }
}
