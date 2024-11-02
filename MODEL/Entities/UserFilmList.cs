using MODEL.Abstract.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class UserFilmList:BaseUserFilmListEntity
    {
        public User Users { get; set; }

        public Film Films { get; set; }
    }
}
