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
    public class FilmArtistConfiguration : IEntityTypeConfiguration<FilmArtist>
    {
        public void Configure(EntityTypeBuilder<FilmArtist> builder)
        {
            builder.HasKey(x => new { x.FilmID, x.ArtistID });

            builder.HasOne(x=>x.Film).WithMany(x=>x.FilmArtist).HasForeignKey(x=>x.FilmID);

            builder.HasOne(x=>x.Artist).WithMany(x=>x.filmArtists).HasForeignKey(x=>x.ArtistID);
        }
    }
}
