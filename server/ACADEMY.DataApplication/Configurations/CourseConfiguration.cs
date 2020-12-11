using ACADEMY.DataApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACADEMY.DataApplication.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course").HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.CourseName).IsRequired();
            builder.Property(e => e.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(e => e.UpdatedDate).HasDefaultValue(DateTime.Now);
            builder.HasOne<Category>(e => e.Category).WithMany(e => e.Courses).HasForeignKey(e => e.CategoryId);
            builder.HasOne<User>(e => e.Teacher).WithMany(e => e.Courses).HasForeignKey(e => e.TeacherId);
        }
    }
}
