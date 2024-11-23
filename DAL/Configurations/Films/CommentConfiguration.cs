using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities.FilmEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations.Films
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasOne(x => x.Film).WithMany(x => x.Comments).HasForeignKey(x => x.FilmID);

            builder.HasOne(x=>x.User).WithMany(x=>x.Comment).HasForeignKey(x => x.UserID);
        }
    }
}
