using ACADEMY.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACADEMY.Data.EF.Configurations
{
    public class CourseDetailConfiguration : IEntityTypeConfiguration<CourseDetail>
    {
        public void Configure(EntityTypeBuilder<CourseDetail> builder)
        {
            builder.ToTable("CourseDetail");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).UseIdentityColumn();

            builder.Property(e => e.Content).IsRequired();

            builder.Property(e => e.IsReview).HasDefaultValue(false);

            builder.Property(e => e.CreatedDate).HasDefaultValueSql("GetDate()");

            builder.Property(e => e.UpdatedDate).HasDefaultValueSql("GetDate()");

            builder.Property(e => e.Done).HasDefaultValue(false);
        }
    }
}