using DAL.FakeData;
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
    public class AwardConfiguration : IEntityTypeConfiguration<Award>
    {
        public void Configure(EntityTypeBuilder<Award> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Film).WithMany(x => x.Awards).HasForeignKey(x => x.FilmID);

            builder.HasData(FilmFaker.Awards);
        }
    }
}
