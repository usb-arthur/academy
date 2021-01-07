using System;
using ACADEMY.Data.EF.Configurations;
using ACADEMY.Data.EF.Extensions;
using ACADEMY.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ACADEMY.Data.EF
{
    public class AcademyDbContext : IdentityDbContext<User, Role, Guid>
    {
        public AcademyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<WatchList> WatchLists { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new CourseConfiguration());
            builder.ApplyConfiguration(new FeedbackConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new StudentCourseConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new WatchListConfiguration());
            builder.ApplyConfiguration(new CourseDetailConfiguration());

            builder
                .Entity<IdentityUserClaim<Guid>>()
                .ToTable("UserClaim");

            builder
                .Entity<IdentityUserRole<Guid>>()
                .ToTable("UserRole")
                .HasKey(e => new {e.RoleId, e.UserId});

            builder
                .Entity<IdentityUserLogin<Guid>>()
                .ToTable("UserLogin")
                .HasKey(x => x.UserId);
            builder
                .Entity<IdentityRoleClaim<Guid>>()
                .ToTable("RoleClaim");
            builder
                .Entity<IdentityUserToken<Guid>>()
                .ToTable("UserToken")
                .HasKey(x => x.UserId);

            /* Data Seeding */
            builder.Seed();
        }
    }
}