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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {

            builder.HasKey(x => x.ID);//OrderID primary key olarak atandı.
            builder.HasOne(x=>x.User).WithMany(x=>x.Order).HasForeignKey("UserID");//UserID foreign key olarak atandı.
            

            
        }
    }
}
