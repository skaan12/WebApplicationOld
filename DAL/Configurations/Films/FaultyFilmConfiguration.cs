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
    internal class FaultyFilmConfiguration : IEntityTypeConfiguration<FaultyFilm>
    {
        public void Configure(EntityTypeBuilder<FaultyFilm> builder)
        {
            builder.HasKey(x => x.ID);

            builder.HasOne(x => x.Film).WithMany(x => x.faultyFilms).HasForeignKey(x => x.FilmID);
            //builder.HasIndex(x => x.Film).IsUnique();
        }
    }
}
