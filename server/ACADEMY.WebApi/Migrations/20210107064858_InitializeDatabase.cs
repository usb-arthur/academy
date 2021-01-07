using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.WebApi.Migrations
{
    public partial class InitializeDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Role",
                table => new
                {
                    Id = table.Column<Guid>("uniqueidentifier", nullable: false),
                    Name = table.Column<string>("nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>("nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>("nvarchar(max)", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Role", x => x.Id); });

            migrationBuilder.CreateTable(
                "RoleClaim",
                table => new
                {
                    Id = table.Column<int>("int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>("uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>("nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>("nvarchar(max)", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_RoleClaim", x => x.Id); });

            migrationBuilder.CreateTable(
                "User",
                table => new
                {
                    Id = table.Column<Guid>("uniqueidentifier", nullable: false),
                    Name = table.Column<string>("nvarchar(250)", maxLength: 250, nullable: false),
                    Gender = table.Column<int>("int", nullable: false),
                    Contact = table.Column<string>("nvarchar(max)", nullable: true),
                    Status = table.Column<int>("int", nullable: false),
                    DateOfBirth = table.Column<DateTime>("datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>("datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>("datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<Guid>("uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>("uniqueidentifier", nullable: false),
                    FirstLogin = table.Column<bool>("bit", nullable: false),
                    RefreshToken = table.Column<string>("nvarchar(max)", nullable: true),
                    UserName = table.Column<string>("nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>("nvarchar(max)", nullable: true),
                    Email = table.Column<string>("nvarchar(450)", nullable: true),
                    NormalizedEmail = table.Column<string>("nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>("bit", nullable: false),
                    PasswordHash = table.Column<string>("nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>("nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>("nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>("nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>("bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>("bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>("datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>("bit", nullable: false),
                    AccessFailedCount = table.Column<int>("int", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_User", x => x.Id); });

            migrationBuilder.CreateTable(
                "UserClaim",
                table => new
                {
                    Id = table.Column<int>("int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>("uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>("nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>("nvarchar(max)", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_UserClaim", x => x.Id); });

            migrationBuilder.CreateTable(
                "UserLogin",
                table => new
                {
                    UserId = table.Column<Guid>("uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>("nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>("nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>("nvarchar(max)", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_UserLogin", x => x.UserId); });

            migrationBuilder.CreateTable(
                "UserRole",
                table => new
                {
                    UserId = table.Column<Guid>("uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>("uniqueidentifier", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_UserRole", x => new {x.RoleId, x.UserId}); });

            migrationBuilder.CreateTable(
                "UserToken",
                table => new
                {
                    UserId = table.Column<Guid>("uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>("nvarchar(max)", nullable: true),
                    Name = table.Column<string>("nvarchar(max)", nullable: true),
                    Value = table.Column<string>("nvarchar(max)", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_UserToken", x => x.UserId); });

            migrationBuilder.CreateTable(
                "Category",
                table => new
                {
                    Id = table.Column<long>("bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>("nvarchar(255)", maxLength: 255, nullable: false),
                    CategoryId = table.Column<long>("bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>("datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>("datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<Guid>("uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>("uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        "FK_Category_Category_CategoryId",
                        x => x.CategoryId,
                        "Category",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_Category_User_CreatedBy",
                        x => x.CreatedBy,
                        "User",
                        "Id");
                    table.ForeignKey(
                        "FK_Category_User_UpdatedBy",
                        x => x.UpdatedBy,
                        "User",
                        "Id");
                });

            migrationBuilder.CreateTable(
                "Course",
                table => new
                {
                    Id = table.Column<long>("bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>("nvarchar(max)", nullable: false),
                    CourseFee = table.Column<double>("float", nullable: false),
                    Sale = table.Column<double>("float", nullable: true, defaultValue: 0.0),
                    SaleDate = table.Column<DateTime>("datetime2", nullable: true),
                    BriefDescription = table.Column<string>("nvarchar(max)", nullable: true),
                    DetailDescription = table.Column<string>("ntext", nullable: true),
                    Status = table.Column<int>("int", nullable: false, defaultValue: 1),
                    CategoryId = table.Column<long>("bigint", nullable: false),
                    TeacherId = table.Column<Guid>("uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>("datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>("datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<Guid>("uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>("uniqueidentifier", nullable: false),
                    SortOrder = table.Column<int>("int", nullable: false),
                    IsDeleted = table.Column<bool>("bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        "FK_Course_Category_CategoryId",
                        x => x.CategoryId,
                        "Category",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_Course_User_TeacherId",
                        x => x.TeacherId,
                        "User",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "CourseDetail",
                table => new
                {
                    Id = table.Column<long>("bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<long>("bigint", nullable: false),
                    Content = table.Column<string>("nvarchar(max)", nullable: false),
                    IsReview = table.Column<bool>("bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>("datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>("datetime2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDetail", x => x.Id);
                    table.ForeignKey(
                        "FK_CourseDetail_Course_CourseId",
                        x => x.CourseId,
                        "Course",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "StudentCourse",
                table => new
                {
                    StudentId = table.Column<Guid>("uniqueidentifier", nullable: false),
                    CourseId = table.Column<long>("bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>("datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>("datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => new {x.StudentId, x.CourseId});
                    table.ForeignKey(
                        "FK_StudentCourse_Course_CourseId",
                        x => x.CourseId,
                        "Course",
                        "Id");
                    table.ForeignKey(
                        "FK_StudentCourse_User_StudentId",
                        x => x.StudentId,
                        "User",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "WatchList",
                table => new
                {
                    Id = table.Column<long>("bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<Guid>("uniqueidentifier", nullable: false),
                    CourseId = table.Column<long>("bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>("datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>("datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<Guid>("uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>("uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchList", x => x.Id);
                    table.UniqueConstraint("AK_WatchList_CourseId_StudentId", x => new {x.CourseId, x.StudentId});
                    table.ForeignKey(
                        "FK_WatchList_Course_CourseId",
                        x => x.CourseId,
                        "Course",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_WatchList_User_StudentId",
                        x => x.StudentId,
                        "User",
                        "Id");
                });

            migrationBuilder.CreateTable(
                "Feedback",
                table => new
                {
                    Id = table.Column<long>("bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>("nvarchar(max)", nullable: true),
                    Rate = table.Column<int>("int", nullable: false),
                    StudentId = table.Column<Guid>("uniqueidentifier", nullable: false),
                    CourseId = table.Column<long>("bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>("datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>("datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<Guid>("uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>("uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                    table.ForeignKey(
                        "FK_Feedback_Course_CourseId",
                        x => x.CourseId,
                        "Course",
                        "Id");
                    table.ForeignKey(
                        "FK_Feedback_StudentCourse_StudentId_CourseId",
                        x => new {x.StudentId, x.CourseId},
                        "StudentCourse",
                        new[] {"StudentId", "CourseId"},
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                "Role",
                new[] {"Id", "ConcurrencyStamp", "Name", "NormalizedName"},
                new object[,]
                {
                    {
                        new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"), "d71c0a31-a676-4f2c-8bba-a05585021292",
                        "Admin", "admin"
                    },
                    {
                        new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"), "435d1685-796b-4c32-9fbc-5e5d85c5dd5e",
                        "Teacher", "teacher"
                    },
                    {
                        new Guid("85baa706-7544-477e-ba32-004d478a7200"), "429bd273-6714-4505-bccf-98cac6eadbcd",
                        "Student", "student"
                    }
                });

            migrationBuilder.InsertData(
                "User",
                new[]
                {
                    "Id", "AccessFailedCount", "ConcurrencyStamp", "Contact", "CreatedBy", "DateOfBirth", "Email",
                    "EmailConfirmed", "FirstLogin", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail",
                    "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken",
                    "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedBy", "UserName"
                },
                new object[,]
                {
                    {
                        new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"), 1, "",
                        "{'email': 'nhan.nguyenvo1@gmail.com'}", new Guid("00000000-0000-0000-0000-000000000000"),
                        new DateTime(1999, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "nhan.nguyenvo1@gmail.com",
                        true, false, 0, false, null, "Nguyễn Võ Nhân", "nhan.nguyenvo1@gmail.com",
                        "nhan.nguyenvo1@gmail.com",
                        "AQAAAAEAACcQAAAAEFZiQe6mz1zkJ5UUdShlNaeKGqeBh4c+2iWMoL6R2w0Yn1NS/GyhlBnaRiAdP5pjqg==",
                        "0348310590", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"),
                        "nhan.nguyenvo1@gmail.com"
                    },
                    {
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 1, "", "email, message, phone",
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        new DateTime(1999, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NguyenVanHung@gmail.com",
                        true, false, 0, false, null, "Nguyễn Văn Hùng", "NguyenVanHung@gmail.com", "Nguyễn Văn Hùng",
                        "AQAAAAEAACcQAAAAEMTRA0FSAqHjSTR62jwwthpGsaAcQg59tWEHppZZ9TTENOdrnOnliyY06r3r3AtFSw==",
                        "0325874156", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"),
                        "NguyenVanHung@gmail.com"
                    },
                    {
                        new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"), 1, "", "email, message, phone",
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        new DateTime(1998, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "TranVanQuang@gmail.com", true,
                        false, 0, false, null, "Trần Văn Quang", "TranVanQuang@gmail.com", "Trần Văn Quang",
                        "AQAAAAEAACcQAAAAEGqgxhQB2PiRt444cV0SYWp8Yox6HOOrW5AEfmsw5NIw+RV6eEXF5hw6UMdoB/ei1Q==",
                        "0325855156", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"),
                        "TranVanQuang@gmail.com"
                    },
                    {
                        new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"), 1, "", "email, message, phone",
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        new DateTime(2000, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "PhamThiNhung@gmail.com", true,
                        false, 1, false, null, "Phạm Thị Nhung", "PhamThiNhung@gmail.com", "Phạm Thị Nhung",
                        "AQAAAAEAACcQAAAAEN0cPrt6j5lRyseMdq2JSTL8NHD9fV+8uZ+cis8y/J8zC2sMybge2l7/NGtd2q5x/A==",
                        "0326675156", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"),
                        "PhamThiNhung@gmail.com"
                    },
                    {
                        new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"), 1, "", "email, message, phone",
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        new DateTime(2002, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "PhanThiThuy@gmail.com", true,
                        false, 1, false, null, "Phan Thị Thủy", "PhanThiThuy@gmail.com", "Phan Thị Thủy",
                        "AQAAAAEAACcQAAAAEIihu2I4JHpX1YeB+L40fEkKA6Uw0bF7/BT8SSviIRzu6MksIteVopV83AD0Xmgmvg==",
                        "0326675233", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"),
                        "PhanThiThuy@gmail.com"
                    },
                    {
                        new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"), 1, "", "email, message, phone",
                        new Guid("00000000-0000-0000-0000-000000000000"),
                        new DateTime(2001, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "HoQuangPhu@gmail.com", true,
                        false, 0, false, null, "Hồ Quang Phú", "HoQuangPhu@gmail.com", "Hồ Quang Phú",
                        "AQAAAAEAACcQAAAAENpdgbSXXDF+NERR1v0H5HXuEl4JbnygUythf6uENHkSZemt/6gujhiC56EeU/CpbQ==",
                        "0326676666", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"),
                        "HoQuangPhu@gmail.com"
                    }
                });

            migrationBuilder.InsertData(
                "UserRole",
                new[] {"RoleId", "UserId"},
                new object[,]
                {
                    {
                        new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                        new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d")
                    },
                    {new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"), new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d")}
                });

            migrationBuilder.InsertData(
                "Category",
                new[] {"Id", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate"},
                new object[]
                {
                    1L, null, "Công nghệ thông tin", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 354, DateTimeKind.Local).AddTicks(355),
                    new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 354, DateTimeKind.Local).AddTicks(9352)
                });

            migrationBuilder.InsertData(
                "Category",
                new[] {"Id", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate"},
                new object[]
                {
                    2L, null, "Ngoại ngữ", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(355),
                    new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(376)
                });

            migrationBuilder.InsertData(
                "Category",
                new[] {"Id", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate"},
                new object[]
                {
                    3L, null, "Thiết kế", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(399),
                    new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(400)
                });

            migrationBuilder.InsertData(
                "Category",
                new[] {"Id", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate"},
                new object[,]
                {
                    {
                        4L, 1L, "Cơ sở dữ liệu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(700),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(706)
                    },
                    {
                        5L, 1L, "Ngôn ngữ lập trình", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(721),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(723)
                    },
                    {
                        6L, 1L, "Lập trình web", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(724),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(726)
                    },
                    {
                        7L, 2L, "Tiếng Hoa", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(727),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(728)
                    },
                    {
                        8L, 2L, "Tiếng Anh", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(730),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(731)
                    },
                    {
                        9L, 2L, "Tiếng Nhật", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(733),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(734)
                    },
                    {
                        10L, 3L, "Phần mềm thiết kế", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(736),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(737)
                    },
                    {
                        11L, 3L, "Thiết kế đồ họa", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(738),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(739)
                    },
                    {
                        12L, 3L, "Thiết kế 3D", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(741),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(742)
                    }
                });

            migrationBuilder.InsertData(
                "Course",
                new[]
                {
                    "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate",
                    "DetailDescription", "SaleDate", "SortOrder", "TeacherId", "UpdatedBy", "UpdatedDate"
                },
                new object[,]
                {
                    {
                        1L,
                        "Khóa học này sẽ giúp các lập trình viên nắm được nguyên tắc, cú pháp và cách thức hoạt động của SQL (Structured Query Language).",
                        4L, 500000.0, "Làm quen với SQL", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(3054),
                        "Khóa học này sẽ giúp các lập trình viên nắm được nguyên tắc, cú pháp và cách thức hoạt động của SQL (Structured Query Language).",
                        null, 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(3312)
                    },
                    {
                        2L,
                        "Khóa học lập trình C cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản và là nền tảng để bạn đi xa hơn trên con đường lập trình.",
                        5L, 499000.0, "C cho người mới bắt đầu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4116),
                        "Khóa học lập trình C cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản và là nền tảng để bạn đi xa hơn trên con đường lập trình.",
                        null, 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4128)
                    }
                });

            migrationBuilder.InsertData(
                "Course",
                new[]
                {
                    "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate",
                    "DetailDescription", "SaleDate", "SortOrder", "Status", "TeacherId", "UpdatedBy", "UpdatedDate"
                },
                new object[]
                {
                    3L, "bắt đầu lập trình Web từ những vấn đề cơ bản nhất", 6L, 700000.0, "Nhập môn lập trình Web",
                    new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4151),
                    "bắt đầu lập trình Web từ những vấn đề cơ bản nhất", null, 0, 1,
                    new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4152)
                });

            migrationBuilder.InsertData(
                "Course",
                new[]
                {
                    "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate",
                    "DetailDescription", "SaleDate", "SortOrder", "TeacherId", "UpdatedBy", "UpdatedDate"
                },
                new object[,]
                {
                    {
                        5L,
                        "Khóa học tiếng Trung dễ hiểu, lôi cuốn cho người mới bắt đầu, được thiết kế dựa trên giáo trình Boya Chinese của Đại học Văn hóa và Ngôn ngữ Bắc Kinh.",
                        7L, 599000.0, "Tiếng Trung cơ bản", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4157),
                        "Khóa học tiếng Trung dễ hiểu, lôi cuốn cho người mới bắt đầu, được thiết kế dựa trên giáo trình Boya Chinese của Đại học Văn hóa và Ngôn ngữ Bắc Kinh.",
                        null, 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4158)
                    },
                    {
                        4L, "Trọn bộ kỹ năng tiếng anh cơ bản. Giao tiếp tiếng Anh từ con số 0.", 8L, 499000.0,
                        "Tiếng Anh cho người bắt đầu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4154),
                        "Trọn bộ kỹ năng tiếng anh cơ bản. Giao tiếp tiếng Anh từ con số 0.", null, 0,
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4155)
                    }
                });

            migrationBuilder.InsertData(
                "Course",
                new[]
                {
                    "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate",
                    "DetailDescription", "SaleDate", "SortOrder", "Status", "TeacherId", "UpdatedBy", "UpdatedDate"
                },
                new object[]
                {
                    6L, "Khóa học này sẽ giúp bạn làm quen với tiếng Nhật và có kiến thức nền tảng.", 9L, 666000.0,
                    "Tiếng Nhật cơ bản cho người bắt đầu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4161),
                    "Khóa học này sẽ giúp bạn làm quen với tiếng Nhật và có kiến thức nền tảng.", null, 0, 1,
                    new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4162)
                });

            migrationBuilder.InsertData(
                "Course",
                new[]
                {
                    "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate",
                    "DetailDescription", "SaleDate", "SortOrder", "TeacherId", "UpdatedBy", "UpdatedDate"
                },
                new object[]
                {
                    7L, "Trở thành nhà thiết kế chuyên nghiệp với Photoshop", 10L, 299000.0, "Học Photoshop trọn bộ",
                    new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4164),
                    "Trở thành nhà thiết kế chuyên nghiệp với Photoshop.", null, 0,
                    new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4165)
                });

            migrationBuilder.InsertData(
                "Course",
                new[]
                {
                    "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate",
                    "DetailDescription", "SaleDate", "SortOrder", "Status", "TeacherId", "UpdatedBy", "UpdatedDate"
                },
                new object[]
                {
                    8L, "Học thiết kế đồ họa với Adobe CC trong khóa học mới này!", 11L, 499000.0,
                    "Học thiết kế đồ họa trọn bộ", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4167),
                    "Học thiết kế đồ họa với Adobe CC trong khóa học mới này!", null, 0, 1,
                    new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4168)
                });

            migrationBuilder.InsertData(
                "StudentCourse",
                new[] {"CourseId", "StudentId", "CreatedDate", "UpdatedDate"},
                new object[,]
                {
                    {
                        1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                    },
                    {
                        2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                    },
                    {
                        3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                    },
                    {
                        5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                    },
                    {
                        4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                    }
                });

            migrationBuilder.InsertData(
                "WatchList",
                new[] {"Id", "CourseId", "CreatedBy", "CreatedDate", "StudentId", "UpdatedBy", "UpdatedDate"},
                new object[,]
                {
                    {
                        1L, 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(6192),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(6456)
                    },
                    {
                        2L, 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7407),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7433)
                    },
                    {
                        3L, 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7452),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7454)
                    },
                    {
                        5L, 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7458),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7459)
                    },
                    {
                        4L, 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7455),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                        new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7456)
                    }
                });

            migrationBuilder.InsertData(
                "Feedback",
                new[]
                {
                    "Id", "Content", "CourseId", "CreatedBy", "CreatedDate", "Rate", "StudentId", "UpdatedBy",
                    "UpdatedDate"
                },
                new object[]
                {
                    1L, "Tạm được", 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(8840), 7,
                    new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9082)
                });

            migrationBuilder.InsertData(
                "Feedback",
                new[]
                {
                    "Id", "Content", "CourseId", "CreatedBy", "CreatedDate", "Rate", "StudentId", "UpdatedBy",
                    "UpdatedDate"
                },
                new object[]
                {
                    2L, "Khóa học rất tốt", 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9830), 9,
                    new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9841)
                });

            migrationBuilder.InsertData(
                "Feedback",
                new[]
                {
                    "Id", "Content", "CourseId", "CreatedBy", "CreatedDate", "Rate", "StudentId", "UpdatedBy",
                    "UpdatedDate"
                },
                new object[]
                {
                    3L, "Khóa học rất bổ ích", 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9862), 8,
                    new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9863)
                });

            migrationBuilder.CreateIndex(
                "IX_Category_CategoryId",
                "Category",
                "CategoryId");

            migrationBuilder.CreateIndex(
                "IX_Category_CreatedBy",
                "Category",
                "CreatedBy");

            migrationBuilder.CreateIndex(
                "IX_Category_UpdatedBy",
                "Category",
                "UpdatedBy");

            migrationBuilder.CreateIndex(
                "IX_Course_CategoryId",
                "Course",
                "CategoryId");

            migrationBuilder.CreateIndex(
                "IX_Course_TeacherId",
                "Course",
                "TeacherId");

            migrationBuilder.CreateIndex(
                "IX_CourseDetail_CourseId",
                "CourseDetail",
                "CourseId");

            migrationBuilder.CreateIndex(
                "IX_Feedback_CourseId",
                "Feedback",
                "CourseId");

            migrationBuilder.CreateIndex(
                "IX_Feedback_StudentId_CourseId",
                "Feedback",
                new[] {"StudentId", "CourseId"});

            migrationBuilder.CreateIndex(
                "IX_StudentCourse_CourseId",
                "StudentCourse",
                "CourseId");

            migrationBuilder.CreateIndex(
                "IX_User_Email",
                "User",
                "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                "IX_WatchList_StudentId",
                "WatchList",
                "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "CourseDetail");

            migrationBuilder.DropTable(
                "Feedback");

            migrationBuilder.DropTable(
                "Role");

            migrationBuilder.DropTable(
                "RoleClaim");

            migrationBuilder.DropTable(
                "UserClaim");

            migrationBuilder.DropTable(
                "UserLogin");

            migrationBuilder.DropTable(
                "UserRole");

            migrationBuilder.DropTable(
                "UserToken");

            migrationBuilder.DropTable(
                "WatchList");

            migrationBuilder.DropTable(
                "StudentCourse");

            migrationBuilder.DropTable(
                "Course");

            migrationBuilder.DropTable(
                "Category");

            migrationBuilder.DropTable(
                "User");
        }
    }
}