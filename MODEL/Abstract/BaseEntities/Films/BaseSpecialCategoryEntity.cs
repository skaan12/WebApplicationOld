using MODEL.Abstract.Interfaces.AboutFilms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Films
{
    public abstract class BaseSpecialCategoryEntity : BaseEntity, ISpecialCategory
    {
        public string Name { get ; set ; }
        public string Description { get ; set ; }
        public DateTime? StartDate { get ; set ; }
        public DateTime? EndDate { get ; set ; }
    }
}
