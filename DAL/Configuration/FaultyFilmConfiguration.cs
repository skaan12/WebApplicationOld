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
    internal class FaultyFilmConfiguration : IEntityTypeConfiguration<FaultyFilm>
    {
        public void Configure(EntityTypeBuilder<FaultyFilm> builder)
        {
            builder.HasKey(x=>x.ID);

            builder.HasOne(x => x.Film).WithMany(x => x.faultyFilms).HasForeignKey(x => x.FilmID);
        }
    }
}
