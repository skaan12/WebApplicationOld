using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations.Users
{
    public class UserFilmRentalConfiguration : IEntityTypeConfiguration<UserFilmRental>
    {
        public void Configure(EntityTypeBuilder<UserFilmRental> builder)
        {
            builder.HasKey(x => new
            {
                x.UserID,
                x.FilmID
            });
            builder.HasOne(x => x.User).WithMany(x => x.userFilmRentals).HasForeignKey(x => x.UserID);
            builder.HasOne(x=>x.Film).WithMany(x=>x.userFilmRental).HasForeignKey(x => x.FilmID);
        }
    }
}
