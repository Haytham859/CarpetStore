
using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetSystem.DAL.ModelConfiguration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).UseIdentityColumn(1, 1);
            builder.Property(a => a.Name).HasMaxLength(50).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(1000).IsRequired();
            builder.Property(a => a.Price).IsRequired();
            builder.HasOne(a => a.Category).WithMany(a => a.Products).HasForeignKey(a => a.CategoryId);
        }
    }
}
