using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.WebApi.Migrations
{
    public partial class InitializeDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstLogin = table.Column<bool>(type: "bit", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.RoleId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseFee = table.Column<double>(type: "float", nullable: false),
                    BriefDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailDescription = table.Column<string>(type: "ntext", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_User_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourse_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourse_User_StudentId",
                        column: x => x.StudentId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WatchList",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchList", x => new { x.CourseId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_WatchList_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WatchList_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedback_StudentCourse_StudentId_CourseId",
                        columns: x => new { x.StudentId, x.CourseId },
                        principalTable: "StudentCourse",
                        principalColumns: new[] { "StudentId", "CourseId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, null, "Công nghệ thông tin", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 704, DateTimeKind.Local).AddTicks(8641), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(7957) },
                    { 2L, null, "Ngoại ngữ", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(8993), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9013) },
                    { 3L, null, "Thiết kế", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9038), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9040) }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"), "646331f6-776d-4427-841e-b2fc00f00dae", "Admin", "admin" },
                    { new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"), "5c87a6d7-1614-418f-9fe7-726146ac5b64", "Teacher", "teacher" },
                    { new Guid("85baa706-7544-477e-ba32-004d478a7200"), "356f1ba0-d45a-4baa-b6c0-5cb73cc64bf7", "Student", "student" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Contact", "CreatedBy", "DateOfBirth", "Email", "EmailConfirmed", "FirstLogin", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"), 1, "", "{'email': 'nhan.nguyenvo1@gmail.com'}", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1999, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "nhan.nguyenvo1@gmail.com", true, false, 0, false, null, "Nguyễn Võ Nhân", "nhan.nguyenvo1@gmail.com", "nhan.nguyenvo1@gmail.com", "AQAAAAEAACcQAAAAEJ7tlnjo7a3zKIKxrCg8Z8Dx2gwP9zV4dp5azRFO67nJMHQJNHL8mGZYay0N1Gd3EA==", "0348310590", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "nhan.nguyenvo1@gmail.com" },
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1999, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NguyenVanHung@gmail.com", true, false, 0, false, null, "Nguyễn Văn Hùng", "NguyenVanHung@gmail.com", "Nguyễn Văn Hùng", "AQAAAAEAACcQAAAAEAWw4kvLL1qMbXKphY+ObrJo87bZPNJWJxO31RyN9ryVKH5YTA2Ke0zLWI26l29QEA==", "0325874156", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "NguyenVanHung@gmail.com" },
                    { new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1998, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "TranVanQuang@gmail.com", true, false, 0, false, null, "Trần Văn Quang", "TranVanQuang@gmail.com", "Trần Văn Quang", "AQAAAAEAACcQAAAAENqCRTVfhNvQJOE6ZFInVwEue3uUmZjI0CSv7vXdx6XM3fFPeH2U8YjUY1gURSXxnw==", "0325855156", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "TranVanQuang@gmail.com" },
                    { new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2000, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "PhamThiNhung@gmail.com", true, false, 1, false, null, "Phạm Thị Nhung", "PhamThiNhung@gmail.com", "Phạm Thị Nhung", "AQAAAAEAACcQAAAAEEaOjMBoic6kzn6uIpNiyBOawbMdyO3S5X/Ut6mp7C2vxONNMlDXNh9cyxxZPqxIBA==", "0326675156", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "PhamThiNhung@gmail.com" },
                    { new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2002, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "PhanThiThuy@gmail.com", true, false, 1, false, null, "Phan Thị Thủy", "PhanThiThuy@gmail.com", "Phan Thị Thủy", "AQAAAAEAACcQAAAAEEiYnnJZsWcbRKbJIjossQgXO0TyQfRTsI8Pc0aV5SBdOoGvAq57xf7rci4ju3V6JQ==", "0326675233", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "PhanThiThuy@gmail.com" },
                    { new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "HoQuangPhu@gmail.com", true, false, 0, false, null, "Hồ Quang Phú", "HoQuangPhu@gmail.com", "Hồ Quang Phú", "AQAAAAEAACcQAAAAEF+NAzJBh0CphwXcTRKO+W9czG/MYpixeNtGfxf69r1DIYyUK29fF4eZOQMvlhwGtw==", "0326676666", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "HoQuangPhu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"), new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d") },
                    { new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"), new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d") }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 4L, 1L, "Cơ sở dữ liệu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9545), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9549) },
                    { 5L, 1L, "Ngôn ngữ lập trình", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9584), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9586) },
                    { 6L, 1L, "Lập trình web", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9589), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9590) },
                    { 7L, 2L, "Tiếng Hoa", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9592), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9593) },
                    { 8L, 2L, "Tiếng Anh", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9594), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9595) },
                    { 9L, 2L, "Tiếng Nhật", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9598), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9599) },
                    { 10L, 3L, "Phần mềm thiết kế", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9601), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9602) },
                    { 11L, 3L, "Thiết kế đồ họa", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9603), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9604) },
                    { 12L, 3L, "Thiết kế 3D", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9607), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 705, DateTimeKind.Local).AddTicks(9608) }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate", "DetailDescription", "SortOrder", "TeacherId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, "Khóa học này sẽ giúp các lập trình viên nắm được nguyên tắc, cú pháp và cách thức hoạt động của SQL (Structured Query Language).", 4L, 500000.0, "Làm quen với SQL", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(2391), "Khóa học này sẽ giúp các lập trình viên nắm được nguyên tắc, cú pháp và cách thức hoạt động của SQL (Structured Query Language).", 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(2685) },
                    { 2L, "Khóa học lập trình C cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản và là nền tảng để bạn đi xa hơn trên con đường lập trình.", 5L, 499000.0, "C cho người mới bắt đầu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3598), "Khóa học lập trình C cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản và là nền tảng để bạn đi xa hơn trên con đường lập trình.", 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3611) }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate", "DetailDescription", "SortOrder", "Status", "TeacherId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3L, "bắt đầu lập trình Web từ những vấn đề cơ bản nhất", 6L, 700000.0, "Nhập môn lập trình Web", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3636), "bắt đầu lập trình Web từ những vấn đề cơ bản nhất", 0, 1, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate", "DetailDescription", "SortOrder", "TeacherId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 5L, "Khóa học tiếng Trung dễ hiểu, lôi cuốn cho người mới bắt đầu, được thiết kế dựa trên giáo trình Boya Chinese của Đại học Văn hóa và Ngôn ngữ Bắc Kinh.", 7L, 599000.0, "Tiếng Trung cơ bản", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3642), "Khóa học tiếng Trung dễ hiểu, lôi cuốn cho người mới bắt đầu, được thiết kế dựa trên giáo trình Boya Chinese của Đại học Văn hóa và Ngôn ngữ Bắc Kinh.", 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3644) },
                    { 4L, "Trọn bộ kỹ năng tiếng anh cơ bản. Giao tiếp tiếng Anh từ con số 0.", 8L, 499000.0, "Tiếng Anh cho người bắt đầu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3639), "Trọn bộ kỹ năng tiếng anh cơ bản. Giao tiếp tiếng Anh từ con số 0.", 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3640) }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate", "DetailDescription", "SortOrder", "Status", "TeacherId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 6L, "Khóa học này sẽ giúp bạn làm quen với tiếng Nhật và có kiến thức nền tảng.", 9L, 666000.0, "Tiếng Nhật cơ bản cho người bắt đầu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3646), "Khóa học này sẽ giúp bạn làm quen với tiếng Nhật và có kiến thức nền tảng.", 0, 1, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate", "DetailDescription", "SortOrder", "TeacherId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 7L, "Trở thành nhà thiết kế chuyên nghiệp với Photoshop", 10L, 299000.0, "Học Photoshop trọn bộ", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3649), "Trở thành nhà thiết kế chuyên nghiệp với Photoshop.", 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate", "DetailDescription", "SortOrder", "Status", "TeacherId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 8L, "Học thiết kế đồ họa với Adobe CC trong khóa học mới này!", 11L, 499000.0, "Học thiết kế đồ họa trọn bộ", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3652), "Học thiết kế đồ họa với Adobe CC trong khóa học mới này!", 0, 1, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.InsertData(
                table: "StudentCourse",
                columns: new[] { "CourseId", "StudentId", "CreatedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WatchList",
                columns: new[] { "CourseId", "StudentId", "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(6037), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(6322), null },
                    { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(7348), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(7382), null },
                    { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(7423), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(7425), null },
                    { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(7429), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(7430), null },
                    { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(7426), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(7427), null }
                });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "Content", "CourseId", "CreatedBy", "CreatedDate", "Rate", "StudentId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1L, "Tạm được", 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 706, DateTimeKind.Local).AddTicks(9925), 7, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 707, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "Content", "CourseId", "CreatedBy", "CreatedDate", "Rate", "StudentId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 2L, "Khóa học rất tốt", 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 707, DateTimeKind.Local).AddTicks(1271), 9, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 707, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "Content", "CourseId", "CreatedBy", "CreatedDate", "Rate", "StudentId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3L, "Khóa học rất bổ ích", 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 707, DateTimeKind.Local).AddTicks(1311), 8, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 5, 23, 20, 24, 707, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryId",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_CategoryId",
                table: "Course",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_TeacherId",
                table: "Course",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_StudentId_CourseId",
                table: "Feedback",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WatchList_UserId",
                table: "WatchList",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "RoleClaim");

            migrationBuilder.DropTable(
                name: "UserClaim");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserToken");

            migrationBuilder.DropTable(
                name: "WatchList");

            migrationBuilder.DropTable(
                name: "StudentCourse");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
