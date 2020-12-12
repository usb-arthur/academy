using System;
using ACADEMY.Data.Configurations;
using ACADEMY.Data.Entities;
using ACADEMY.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ACADEMY.Data.EF
{
    internal class AcademyDbContext : IdentityDbContext<User, Role, Guid>
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

            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaim");
            builder.Entity<IdentityUserRole<Guid>>()
                .ToTable("UserRole")
                .HasKey(x => new {x.UserId, x.RoleId});
            builder.Entity<IdentityUserLogin<Guid>>()
                .ToTable("UserLogin")
                .HasKey(x => x.UserId);
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaim");
            builder.Entity<IdentityUserToken<Guid>>()
                .ToTable("UserToken")
                .HasKey(x => x.UserId);

            /* Data Seeding */
            builder.Seed();
        }
    }
}