using MODEL.Abstract.Interfaces.AboutFilms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract.BaseEntities.Films
{
    public abstract class BaseCommentEntity : BaseEntity, IComment
    {
        public int FilmID { get ; set ; }
        public string Content { get ; set ; }
        public DateTime CommentDate { get ; set ; }
        public string UserID { get ; set ; }
    }
}
