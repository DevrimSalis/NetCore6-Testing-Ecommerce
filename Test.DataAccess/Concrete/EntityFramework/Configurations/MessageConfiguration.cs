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
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();
            builder.Property(m => m.FullName).HasMaxLength(150).IsRequired();
            builder.Property(m => m.Email).HasMaxLength(70).IsRequired();
            builder.Property(m => m.Subject).HasMaxLength(50).IsRequired();
            builder.Property(m => m.Content).HasMaxLength(5000).IsRequired();
        }
    }
}
