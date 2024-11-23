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
    public class UserWatchListConfiguration : IEntityTypeConfiguration<UserWatchList>
    {
        public void Configure(EntityTypeBuilder<UserWatchList> builder)
        {
            builder.HasKey(x => new
            {
                x.UserID,
                x.FilmID
            });
            builder.HasOne(x=>x.User).WithMany(x=>x.UserWatchList).HasForeignKey(x=>x.UserID);

            builder.HasOne(x=>x.Film).WithMany(x=>x.userWatchLists).HasForeignKey(x=>x.FilmID);
        }
    }
}
