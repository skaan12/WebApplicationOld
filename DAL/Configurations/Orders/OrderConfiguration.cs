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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {

            builder.HasKey(x => x.ID);//OrderID primary key olarak atandı.
            builder.HasOne(x => x.User).WithMany(x => x.Order).HasForeignKey("UserID");//UserID foreign key olarak atandı.
            //builder.HasIndex(x => x.Delivery).IsUnique();





        }
    }
}
