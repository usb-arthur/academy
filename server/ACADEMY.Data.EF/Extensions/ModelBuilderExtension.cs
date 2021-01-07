using System;
using System.Collections.Generic;
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
                new Role()
                {
                    Id = new Guid("AD0E4E6A-FEE6-4CCF-91EB-5F357E04E467"),
                    Name = "Admin",
                    NormalizedName = "admin"
                },
                new Role()
                {
                    Id = new Guid("09E89E3B-00DD-4580-A403-63FC3F91AB50"),
                    Name = "Teacher",
                    NormalizedName = "teacher"
                },
                new Role()
                {
                    Id = new Guid("85BAA706-7544-477E-BA32-004D478A7200"),
                    Name = "Student",
                    NormalizedName = "student"
                });
            
            var userId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            var hasher = new PasswordHasher<User>();
            
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = new Guid("EAFEF07D-95FB-473D-B38E-57EA4A29968D"),
                    Name = "Nguyễn Võ Nhân",
                    Gender = UserGender.Male,
                    Contact = "{'email': 'nhan.nguyenvo1@gmail.com'}",
                    Status = UserStatus.Active,
                    DateOfBirth = new DateTime(1999, 3, 15),
                    UserName = "nhan.nguyenvo1@gmail.com",
                    NormalizedUserName = "nhan.nguyenvo1@gmail.com",
                    Email = "nhan.nguyenvo1@gmail.com",
                    NormalizedEmail = "nhan.nguyenvo1@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "@dmin12345"),
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = string.Empty,
                    PhoneNumber = "0348310590",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 1
                },
                new User()
                {
                    Id = userId,
                    Name = "Nguyễn Văn Hùng",
                    Gender = Enums.UserGender.Male,
                    Contact = "email, message, phone",
                    Status = Enums.UserStatus.Active,
                    DateOfBirth = new DateTime(1999, 01, 31),
                    UserName = "NguyenVanHung@gmail.com",
                    NormalizedUserName = "Nguyễn Văn Hùng",
                    Email = "NguyenVanHung@gmail.com",
                    NormalizedEmail = "NguyenVanHung@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "@dmin12345"),
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = string.Empty,
                    PhoneNumber = "0325874156",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 1
                },
                new User()
                {
                    Id = new Guid("C6F46571-9F16-4C94-9F78-FB5C56B7CAA9"),
                    Name = "Trần Văn Quang",
                    Gender = Enums.UserGender.Male,
                    Contact = "email, message, phone",
                    Status = Enums.UserStatus.Active,
                    DateOfBirth = new DateTime(1998, 02, 15),
                    UserName = "TranVanQuang@gmail.com",
                    NormalizedUserName = "Trần Văn Quang",
                    Email = "TranVanQuang@gmail.com",
                    NormalizedEmail = "TranVanQuang@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "@dmin12345"),
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = string.Empty,
                    PhoneNumber = "0325855156",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 1
                },
                new User()
                {
                    Id = new Guid("BABB8ADF-190D-48CA-A9FE-A3B7C06FB58D"),
                    Name = "Phạm Thị Nhung",
                    Gender = Enums.UserGender.Female,
                    Contact = "email, message, phone",
                    Status = Enums.UserStatus.Active,
                    DateOfBirth = new DateTime(2000, 02, 04),
                    UserName = "PhamThiNhung@gmail.com",
                    NormalizedUserName = "Phạm Thị Nhung",
                    Email = "PhamThiNhung@gmail.com",
                    NormalizedEmail = "PhamThiNhung@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "@dmin12345"),
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = string.Empty,
                    PhoneNumber = "0326675156",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 1
                },
                new User()
                {
                    Id = new Guid("92F252EB-F35C-4D29-864A-5FBDCB82BD2E"),
                    Name = "Phan Thị Thủy",
                    Gender = Enums.UserGender.Female,
                    Contact = "email, message, phone",
                    Status = Enums.UserStatus.Active,
                    DateOfBirth = new DateTime(2002, 04, 06),
                    UserName = "PhanThiThuy@gmail.com",
                    NormalizedUserName = "Phan Thị Thủy",
                    Email = "PhanThiThuy@gmail.com",
                    NormalizedEmail = "PhanThiThuy@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "@dmin12345"),
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = string.Empty,
                    PhoneNumber = "0326675233",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 1
                },
                new User()
                {
                    Id = new Guid("E0181BF8-FC45-4122-97B0-1C4990A4983D"),
                    Name = "Hồ Quang Phú",
                    Gender = Enums.UserGender.Male,
                    Contact = "email, message, phone",
                    Status = Enums.UserStatus.Active,
                    DateOfBirth = new DateTime(2001, 05, 06),
                    UserName = "HoQuangPhu@gmail.com",
                    NormalizedUserName = "Hồ Quang Phú",
                    Email = "HoQuangPhu@gmail.com",
                    NormalizedEmail = "HoQuangPhu@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "@dmin12345"),
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = string.Empty,
                    PhoneNumber = "0326676666",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 1
                });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>()
                {
                    RoleId = new Guid("AD0E4E6A-FEE6-4CCF-91EB-5F357E04E467"),
                    UserId = new Guid("EAFEF07D-95FB-473D-B38E-57EA4A29968D"),
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("09E89E3B-00DD-4580-A403-63FC3F91AB50"),
                    UserId = new Guid("E0181BF8-FC45-4122-97B0-1C4990A4983D")
                });
            
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    CategoryName = "Công nghệ thông tin",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Category()
                {
                    Id = 2,
                    CategoryName = "Ngoại ngữ",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Category()
                {
                    Id = 3,
                    CategoryName = "Thiết kế",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Category()
                {
                    Id = 4,
                    CategoryName = "Cơ sở dữ liệu",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Category()
                {
                    Id = 5,
                    CategoryName = "Ngôn ngữ lập trình",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Category()
                {
                    Id = 6,
                    CategoryName = "Lập trình web",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Category()
                {
                    Id = 7,
                    CategoryName = "Tiếng Hoa",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Category()
                {
                    Id = 8,
                    CategoryName = "Tiếng Anh",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Category()
                {
                    Id = 9,
                    CategoryName = "Tiếng Nhật",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Category()
                {
                    Id = 10,
                    CategoryName = "Phần mềm thiết kế",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Category()
                {
                    Id = 11,
                    CategoryName = "Thiết kế đồ họa",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Category()
                {
                    Id = 12,
                    CategoryName = "Thiết kế 3D",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                });
            
            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    Id = 1,
                    CourseName = "Làm quen với SQL",
                    CourseFee = 500000,
                    BriefDescription = "Khóa học này sẽ giúp các lập trình viên nắm được nguyên tắc, cú pháp và cách thức hoạt động của SQL (Structured Query Language).",
                    DetailDescription = "Khóa học này sẽ giúp các lập trình viên nắm được nguyên tắc, cú pháp và cách thức hoạt động của SQL (Structured Query Language).",
                    Status = Enums.CourseStatus.Completed,
                    CategoryId = 4,
                    TeacherId = userId,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Course()
                {
                    Id = 2,
                    CourseName = "C cho người mới bắt đầu",
                    CourseFee = 499000,
                    BriefDescription = "Khóa học lập trình C cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản và là nền tảng để bạn đi xa hơn trên con đường lập trình.",
                    DetailDescription = "Khóa học lập trình C cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản và là nền tảng để bạn đi xa hơn trên con đường lập trình.",
                    Status = Enums.CourseStatus.Completed,
                    CategoryId = 5,
                    TeacherId = userId,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Course()
                {
                    Id = 3,
                    CourseName = "Nhập môn lập trình Web",
                    CourseFee = 700000,
                    BriefDescription = "bắt đầu lập trình Web từ những vấn đề cơ bản nhất",
                    DetailDescription = "bắt đầu lập trình Web từ những vấn đề cơ bản nhất",
                    Status = Enums.CourseStatus.Incomplete,
                    CategoryId = 6,
                    TeacherId = userId,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Course()
                {
                    Id = 4,
                    CourseName = "Tiếng Anh cho người bắt đầu",
                    CourseFee = 499000,
                    BriefDescription = "Trọn bộ kỹ năng tiếng anh cơ bản. Giao tiếp tiếng Anh từ con số 0.",
                    DetailDescription = "Trọn bộ kỹ năng tiếng anh cơ bản. Giao tiếp tiếng Anh từ con số 0.",
                    Status = Enums.CourseStatus.Completed,
                    CategoryId = 8,
                    TeacherId = userId,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Course()
                {
                    Id = 5,
                    CourseName = "Tiếng Trung cơ bản",
                    CourseFee = 599000,
                    BriefDescription = "Khóa học tiếng Trung dễ hiểu, lôi cuốn cho người mới bắt đầu, được thiết kế dựa trên giáo trình Boya Chinese của Đại học Văn hóa và Ngôn ngữ Bắc Kinh.",
                    DetailDescription = "Khóa học tiếng Trung dễ hiểu, lôi cuốn cho người mới bắt đầu, được thiết kế dựa trên giáo trình Boya Chinese của Đại học Văn hóa và Ngôn ngữ Bắc Kinh.",
                    Status = Enums.CourseStatus.Completed,
                    CategoryId = 7,
                    TeacherId = userId,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Course()
                {
                    Id = 6,
                    CourseName = "Tiếng Nhật cơ bản cho người bắt đầu",
                    CourseFee = 666000,
                    BriefDescription = "Khóa học này sẽ giúp bạn làm quen với tiếng Nhật và có kiến thức nền tảng.",
                    DetailDescription = "Khóa học này sẽ giúp bạn làm quen với tiếng Nhật và có kiến thức nền tảng.",
                    Status = Enums.CourseStatus.Incomplete,
                    CategoryId = 9,
                    TeacherId = userId,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Course()
                {
                    Id = 7,
                    CourseName = "Học Photoshop trọn bộ",
                    CourseFee = 299000,
                    BriefDescription = "Trở thành nhà thiết kế chuyên nghiệp với Photoshop",
                    DetailDescription = "Trở thành nhà thiết kế chuyên nghiệp với Photoshop.",
                    Status = Enums.CourseStatus.Completed,
                    CategoryId = 10,
                    TeacherId = userId,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Course()
                {
                    Id = 8,
                    CourseName = "Học thiết kế đồ họa trọn bộ",
                    CourseFee = 499000,
                    BriefDescription = "Học thiết kế đồ họa với Adobe CC trong khóa học mới này!",
                    DetailDescription = "Học thiết kế đồ họa với Adobe CC trong khóa học mới này!",
                    Status = Enums.CourseStatus.Incomplete,
                    CategoryId = 11,
                    TeacherId = userId,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                });
            
            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse()
                {
                    StudentId = userId,
                    CourseId = 1
                },
                new StudentCourse()
                {
                    StudentId = userId,
                    CourseId = 2
                },
                new StudentCourse()
                {
                    StudentId = userId,
                    CourseId = 3
                },
                new StudentCourse()
                {
                    StudentId = userId,
                    CourseId = 4
                },
                new StudentCourse()
                {
                    StudentId = userId,
                    CourseId = 5
                });
            
            modelBuilder.Entity<WatchList>().HasData(
                new WatchList()
                {
                    Id = 1,
                    StudentId = userId,
                    CourseId = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new WatchList()
                {
                    Id = 2,
                    StudentId = userId,
                    CourseId = 2,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new WatchList()
                {
                    Id = 3,
                    StudentId = userId,
                    CourseId = 3,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new WatchList()
                {
                    Id = 4,
                    StudentId = userId,
                    CourseId = 4,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new WatchList()
                {
                    Id = 5,
                    StudentId = userId,
                    CourseId = 5,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                });
            
            modelBuilder.Entity<Feedback>().HasData(
                new Feedback()
                {
                    Id = 1,
                    Content = "Tạm được",
                    Rate = 7,
                    StudentId = userId,
                    CourseId = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Feedback()
                {
                    Id = 2,
                    Content = "Khóa học rất tốt",
                    Rate = 9,
                    StudentId = userId,
                    CourseId = 2,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                },
                new Feedback()
                {
                    Id = 3,
                    Content = "Khóa học rất bổ ích",
                    Rate = 8,
                    StudentId = userId,
                    CourseId = 3,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = userId,
                    UpdatedBy = userId
                });
        }
    }
}