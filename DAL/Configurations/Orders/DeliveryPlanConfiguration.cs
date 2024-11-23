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
    public class DeliveryPlanConfiguration : IEntityTypeConfiguration<DeliveryPlan>
    {
        public void Configure(EntityTypeBuilder<DeliveryPlan> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Delivery).WithMany(x => x.DeliveryPlans).HasForeignKey(x => x.DeliveryID);
        }
    }
}
