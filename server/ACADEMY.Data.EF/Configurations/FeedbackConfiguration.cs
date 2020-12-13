using ACADEMY.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACADEMY.Data.EF.Configurations
{
    public class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder.ToTable("Feedback").HasKey(e => e.Id);

            builder.Property(e => e.Id).UseIdentityColumn();

            builder.Property(e => e.CreatedDate).HasDefaultValueSql("GetDate()");

            builder.Property(e => e.UpdatedDate).HasDefaultValueSql("GetDate()");

            builder
                .HasOne(e => e.StudentCourse)
                .WithMany(e => e.Feedbacks)
                .HasForeignKey(e => new {e.StudentId, e.CourseId});
        }
    }
}