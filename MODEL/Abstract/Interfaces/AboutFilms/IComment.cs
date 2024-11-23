using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.Interfaces.AboutFilms
{
    public interface IComment
    {
        public int FilmID { get; set; }

        public string UserID { get; set; }

        public string Content { get; set; }

        public DateTime CommentDate { get; set; }
    }
}
