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
    public class AdvertisementConfiguration : IEntityTypeConfiguration<Advertisement>
    {
        public void Configure(EntityTypeBuilder<Advertisement> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.CompanyName).HasMaxLength(50).IsRequired();
            builder.Property(a => a.Title).HasMaxLength(250);
            builder.Property(a => a.Image).HasMaxLength(300).IsRequired();
            builder.Property(a => a.ForwardingAddress).HasMaxLength(300);
        }
    }
}
