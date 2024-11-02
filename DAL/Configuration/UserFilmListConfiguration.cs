using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    public class UserFilmListConfiguration : IEntityTypeConfiguration<UserFilmList>
    {
        public void Configure(EntityTypeBuilder<UserFilmList> builder)
        {
            builder.HasKey(x => new { x.UserID, x.FilmID });//Hem UserID hem de FilmID primary key olarak atandı.
            builder.Ignore(x => x.ID);
            
            builder.HasOne(x => x.Films).WithMany(x => x.UserFilmList).HasForeignKey(x => x.FilmID);
            builder.HasOne(x => x.Users).WithMany(x => x.UserFilmList).HasForeignKey(x => x.UserID);
        }
    }
}
