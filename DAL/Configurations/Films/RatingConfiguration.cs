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
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasOne(x => x.Film).WithMany(x => x.ratings).HasForeignKey(x => x.FilmID);

            builder.HasOne(x=>x.User).WithMany(x=>x.Rating).HasForeignKey(x => x.UserID);
        }
    }
}
