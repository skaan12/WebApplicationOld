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
    public class CategoryFilmConfiguration : IEntityTypeConfiguration<CategoryFilm>
    {
        public void Configure(EntityTypeBuilder<CategoryFilm> builder)
        {
            builder.HasKey(x => new
            {
                x.CategoryID,
                x.FilmID
            });
            builder.HasOne(x=>x.Category).WithMany(x=>x.CategoryFilm).HasForeignKey(x=>x.CategoryID);

            builder.HasOne(x=>x.film).WithMany(x=>x.categoryFilms).HasForeignKey(x=>x.FilmID);
        }
    }
}
