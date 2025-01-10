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
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasMany(x=>x.filmArtists).WithOne(x=>x.Artist).HasForeignKey(x=>x.ArtistID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
