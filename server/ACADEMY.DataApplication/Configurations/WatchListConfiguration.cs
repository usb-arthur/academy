using ACADEMY.DataApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACADEMY.DataApplication.Configurations
{
    public class WatchListConfiguration : IEntityTypeConfiguration<WatchList>
    {
        public void Configure(EntityTypeBuilder<WatchList> builder)
        {
            builder.ToTable("WatchList").HasKey(e => new { e.CourseId, e.StudentId });
            builder.Property(e => e.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(e => e.UpdatedDate).HasDefaultValue(DateTime.Now);
        }
    }
}
