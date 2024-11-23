using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutFilms
{
    public interface ICategory
    {
        public string CategoryName { get; set; }

        public string? Description { get; set; }

        public int? ParentCategoryID { get; set; }
    }
}
