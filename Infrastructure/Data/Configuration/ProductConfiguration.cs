using Core.Entities.Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,4)");
            builder.Property(p => p.IsHome).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.HasOne(p => p.Category).WithMany(x => x.Products).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}