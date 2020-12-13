using ACADEMY.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACADEMY.Data.EF.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User").HasKey(e => e.Id);

            builder.Property(e => e.Name).IsRequired().HasMaxLength(250);

            builder.Property(e => e.CreatedDate).HasDefaultValueSql("GetDate()");

            builder.Property(e => e.UpdatedDate).HasDefaultValueSql("GetDate()");
        }
    }
}