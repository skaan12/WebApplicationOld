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
    public class FilmDirectorConfiguration : IEntityTypeConfiguration<FilmDirector>
    {
        public void Configure(EntityTypeBuilder<FilmDirector> builder)
        {
            builder.HasKey(x => new { x.DirectorID, x.FilmID });

            builder.HasOne(x=>x.Film).WithMany(x=>x.filmDirectors).HasForeignKey(x=>x.FilmID);

            builder.HasOne(x=>x.Director).WithMany(x=>x.filmDirectors).HasForeignKey(x=>x.DirectorID);
        }
    }
}
