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
    public class SettingConfiguration : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Title).HasMaxLength(100).IsRequired();
            builder.Property(s => s.Description).HasMaxLength(300).IsRequired();
            builder.Property(s => s.Meta).HasMaxLength(300).IsRequired();
            builder.Property(s => s.PhoneNumber).HasMaxLength(20).IsRequired();
            builder.Property(s => s.WorkDate).HasMaxLength(150).IsRequired();
            builder.Property(s => s.Email).HasMaxLength(70).IsRequired();
        }
    }
}
