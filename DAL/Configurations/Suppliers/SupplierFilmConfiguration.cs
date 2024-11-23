using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities.SupplierEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations.Suppliers
{
    public class SupplierFilmConfiguration : IEntityTypeConfiguration<SupplierFilm>
    {
        public void Configure(EntityTypeBuilder<SupplierFilm> builder)
        {
            builder.HasKey(x => new
            {
                x.SupplierID,
                x.FilmID
            });
            builder.HasOne(x=>x.Supplier).WithMany(x=>x.supplierFilms).HasForeignKey(x=>x.SupplierID);
            builder.HasOne(x=>x.Film).WithMany(x=>x.supplierFilm).HasForeignKey(x=>x.FilmID);
        }
    }
}
