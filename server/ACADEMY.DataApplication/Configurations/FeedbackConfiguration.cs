using ACADEMY.DataApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACADEMY.DataApplication.Configurations
{
    public class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder.ToTable("Feedback").HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(e => e.UpdatedDate).HasDefaultValue(DateTime.Now);
            builder.HasOne<StudentCourse>(e => e.StudentCourse).WithMany(e => e.Feedbacks).HasForeignKey(e => new { e.StudentId, e.CourseId });
        }
    }
}
