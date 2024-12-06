using Bogus;
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
    internal class FilmConfiguration : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.HasOne(x=>x.SpecialCategory).WithMany(x=>x.Film).HasForeignKey(x=>x.SpecialCategoryID);
            
        }



    }
}
