using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutFilms
{
    public interface IDirector
    {
        public string Name { get; set; }

        public string? Biography { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
