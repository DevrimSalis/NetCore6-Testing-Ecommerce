using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.Entities.Concrete;

namespace Test.DataAccess.Concrete.EntityFramework.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Message).HasMaxLength(500).IsRequired();
            builder.HasOne<Customer>(c => c.Customer).WithMany(c => c.Comments).HasForeignKey(c => c.CustomerId);
            builder.HasOne<Product>(c => c.Product).WithMany(p => p.Comments).HasForeignKey(c => c.ProductId);
        }
    }
}
