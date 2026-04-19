using System;
using System.Collections.Generic;
using System.Text;

namespace CarpetSystem.DAL.ModelConfiguration
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).UseIdentityColumn(10, 10);
            builder.Property(a=>a.Name).IsRequired().HasMaxLength(50);

            builder.HasMany(a => a.Products).WithOne().HasForeignKey(a => a.CategoryId);


        }
    }
}
