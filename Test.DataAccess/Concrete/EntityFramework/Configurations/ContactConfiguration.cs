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
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Location).HasMaxLength(400);
            builder.Property(c => c.Address).HasMaxLength(250).IsRequired();
            builder.Property(c => c.MobileNumber).HasMaxLength(20).IsRequired();
            builder.Property(c => c.HotLineNumber).HasMaxLength(20).IsRequired();
            builder.Property(c => c.Email1).HasMaxLength(70).IsRequired();
            builder.Property(c => c.Email2).HasMaxLength(70);
        }
    }
}
