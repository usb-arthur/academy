using ACADEMY.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACADEMY.Data.EF.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category").HasKey(e => e.Id);

            builder.Property(e => e.Id).UseIdentityColumn();

            builder.Property(e => e.CategoryName).HasMaxLength(255).IsRequired();

            builder.Property(e => e.CreatedDate).HasDefaultValueSql("GetDate()");

            builder.Property(e => e.UpdatedDate).HasDefaultValueSql("GetDate()");
        }
    }
}