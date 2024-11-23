using MODEL.Abstract.Interfaces.AboutFilms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Films
{
    public abstract class BaseCategoryEntity : BaseEntity, ICategory
    {
        public string CategoryName { get ; set ; }
        public string? Description { get ; set ; }
        public int? ParentCategoryID { get ; set ; }
    }
}
