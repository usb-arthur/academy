using ACADEMY.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACADEMY.Data.EF.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course").HasKey(e => e.Id);

            builder.Property(e => e.Id).UseIdentityColumn();

            builder.Property(e => e.CourseName).IsRequired();

            builder
                .Property(e => e.DetailDescription)
                .HasColumnType("ntext");

            builder.Property(e => e.CreatedDate).HasDefaultValueSql("GetDate()");

            builder.Property(e => e.UpdatedDate).HasDefaultValueSql("GetDate()");

            builder
                .HasOne(e => e.Category)
                .WithMany(e => e.Courses)
                .HasForeignKey(e => e.CategoryId);

            builder
                .HasOne(e => e.Teacher)
                .WithMany(e => e.Courses)
                .HasForeignKey(e => e.TeacherId);
        }
    }
}