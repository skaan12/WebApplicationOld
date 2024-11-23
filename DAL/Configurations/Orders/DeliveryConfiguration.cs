using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Entities.OrderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations.Orders
{
    public class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.HasKey(x => x.ID);


            builder.HasMany(x => x.Orders).WithOne(x => x.Delivery).HasForeignKey(x => x.DeliveryID);

            //builder.HasIndex(x => x.Courier).IsUnique();










        }
    }
}
