using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Entities.Concrete;

namespace Test.DataAccess.Concrete.EntityFramework.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).ValueGeneratedOnAdd();
            builder.HasOne<Order>(o => o.Order).WithMany(o => o.OrderDetails).HasForeignKey(o => o.OrderId);
            builder.HasOne<Product>(o => o.Product).WithMany(p => p.OrderDetails).HasForeignKey(o => o.ProductId);
        }
    }
}
