using System;
using ACADEMY.Data.Entities;
using ACADEMY.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ACADEMY.Data.EF.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = new Guid("AD0E4E6A-FEE6-4CCF-91EB-5F357E04E467"),
                    Name = "Admin",
                    NormalizedName = "admin"
                },
                new Role
                {
                    Id = new Guid("09E89E3B-00DD-4580-A403-63FC3F91AB50"),
                    Name = "Teacher",
                    NormalizedName = "teacher"
                },
                new Role
                {
                    Id = new Guid("85BAA706-7544-477E-BA32-004D478A7200"),
                    Name = "Student",
                    NormalizedName = "student"
                });

            var userId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            var hasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = new Guid("EAFEF07D-95FB-473D-B38E-57EA4A29968D"),
                    Name = "Nguyễn Võ Nhân",
                    Gender = UserGender.Male,
                    Contact = "{'email': 'nhan.nguyenvo1@gmail.com'}",
                    Status = UserStatus.Active,
                    DateOfBirth = new DateTime(1999, 3, 15),
                    UserName = "admin@gmail.com",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "@dmin12345"),
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = string.Empty,
                    PhoneNumber = "0348310590",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 1
                });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("AD0E4E6A-FEE6-4CCF-91EB-5F357E04E467"),
                    UserId = new Guid("EAFEF07D-95FB-473D-B38E-57EA4A29968D")
                });
        }
    }
}