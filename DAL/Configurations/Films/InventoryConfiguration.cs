using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities.FilmEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations.Films
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.HasKey(x => x.ID);

            builder.HasOne(x=>x.Supplier).WithMany(x=>x.Inventories).HasForeignKey(x=>x.SupplierID);

            builder.HasOne(x=>x.Film).WithMany(x=>x.Inventory).HasForeignKey(x=>x.FilmID);
        }
    }
}
