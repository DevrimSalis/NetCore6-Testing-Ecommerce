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
    public class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
    {
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Facebook).HasMaxLength(300);
            builder.Property(s => s.Twitter).HasMaxLength(300);
            builder.Property(s => s.Instagram).HasMaxLength(300);
            builder.Property(s => s.Youtube).HasMaxLength(300);
        }
    }
}
