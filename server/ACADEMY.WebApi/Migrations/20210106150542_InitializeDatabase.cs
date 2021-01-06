using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.WebApi.Migrations
{
    public partial class InitializeDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    table.ForeignKey(
                        name: "FK_Category_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Category_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
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
                name: "CourseDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<long>(type: "bigint", nullable: false),
                    CourseUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseDetail_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
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
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"), "185d52ef-8f4f-4948-bea2-2c4c4a9c0cd0", "Admin", "admin" },
                    { new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"), "bb86d9d2-3c97-4d2d-b1c8-d9d8ddb692b1", "Teacher", "teacher" },
                    { new Guid("85baa706-7544-477e-ba32-004d478a7200"), "5b162361-961f-40a3-bb86-5d86e5b58051", "Student", "student" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Contact", "CreatedBy", "DateOfBirth", "Email", "EmailConfirmed", "FirstLogin", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"), 1, "", "{'email': 'nhan.nguyenvo1@gmail.com'}", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1999, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "nhan.nguyenvo1@gmail.com", true, false, 0, false, null, "Nguyễn Võ Nhân", "nhan.nguyenvo1@gmail.com", "nhan.nguyenvo1@gmail.com", "AQAAAAEAACcQAAAAEFdWLgV0D3FigBz7B/T6kCK05lCEwDSEwUa+NyD9vHEW/oT3Ixh9DqauEMTzCzDXFg==", "0348310590", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "nhan.nguyenvo1@gmail.com" },
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1999, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NguyenVanHung@gmail.com", true, false, 0, false, null, "Nguyễn Văn Hùng", "NguyenVanHung@gmail.com", "Nguyễn Văn Hùng", "AQAAAAEAACcQAAAAEC2t6aKpk/axSFDN2unC1lXYrUDldfzY+B3276hlGOlViU8tNZ4S4WeqEUBgAy9SWQ==", "0325874156", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "NguyenVanHung@gmail.com" },
                    { new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1998, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "TranVanQuang@gmail.com", true, false, 0, false, null, "Trần Văn Quang", "TranVanQuang@gmail.com", "Trần Văn Quang", "AQAAAAEAACcQAAAAEBClKfdP3DSq5SfpiwZr595uC7Oy7JzAmSEjdGxbsF1qigvhNhTHcw7spoZqTDKp8Q==", "0325855156", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "TranVanQuang@gmail.com" },
                    { new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2000, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "PhamThiNhung@gmail.com", true, false, 1, false, null, "Phạm Thị Nhung", "PhamThiNhung@gmail.com", "Phạm Thị Nhung", "AQAAAAEAACcQAAAAEMRZhXkNzH+bUhYekGnTxIkPomlXCzzIn4WCNoQs//LFGDnNlYft1Z61ggRb0SpplA==", "0326675156", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "PhamThiNhung@gmail.com" },
                    { new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2002, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "PhanThiThuy@gmail.com", true, false, 1, false, null, "Phan Thị Thủy", "PhanThiThuy@gmail.com", "Phan Thị Thủy", "AQAAAAEAACcQAAAAEGSOSZLmB3mdwcvSS59vHshq3izWcYKP3AC9pAnsDSlnLMpuhZyDZjo+NNLtdoLmbg==", "0326675233", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "PhanThiThuy@gmail.com" },
                    { new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "HoQuangPhu@gmail.com", true, false, 0, false, null, "Hồ Quang Phú", "HoQuangPhu@gmail.com", "Hồ Quang Phú", "AQAAAAEAACcQAAAAEIUwf5t1jFUWUTccnjNgL+GIH0TxYS++Zs0Tcybbgsm+FcYWJz/4DVeDzVosb+KCiw==", "0326676666", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "HoQuangPhu@gmail.com" }
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
                values: new object[] { 1L, null, "Công nghệ thông tin", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 842, DateTimeKind.Local).AddTicks(2709), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 2L, null, "Ngoại ngữ", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(4980), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3L, null, "Thiết kế", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5021), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 4L, 1L, "Cơ sở dữ liệu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5326), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5330) },
                    { 5L, 1L, "Ngôn ngữ lập trình", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5345), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5346) },
                    { 6L, 1L, "Lập trình web", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5348), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5349) },
                    { 7L, 2L, "Tiếng Hoa", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5351), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5352) },
                    { 8L, 2L, "Tiếng Anh", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5354), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5355) },
                    { 9L, 2L, "Tiếng Nhật", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5357), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5358) },
                    { 10L, 3L, "Phần mềm thiết kế", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5359), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5361) },
                    { 11L, 3L, "Thiết kế đồ họa", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5362), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5363) },
                    { 12L, 3L, "Thiết kế 3D", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5366), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5367) }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate", "DetailDescription", "SortOrder", "TeacherId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, "Khóa học này sẽ giúp các lập trình viên nắm được nguyên tắc, cú pháp và cách thức hoạt động của SQL (Structured Query Language).", 4L, 500000.0, "Làm quen với SQL", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(7981), "Khóa học này sẽ giúp các lập trình viên nắm được nguyên tắc, cú pháp và cách thức hoạt động của SQL (Structured Query Language).", 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(8239) },
                    { 2L, "Khóa học lập trình C cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản và là nền tảng để bạn đi xa hơn trên con đường lập trình.", 5L, 499000.0, "C cho người mới bắt đầu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9048), "Khóa học lập trình C cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản và là nền tảng để bạn đi xa hơn trên con đường lập trình.", 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9062) }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate", "DetailDescription", "SortOrder", "Status", "TeacherId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3L, "bắt đầu lập trình Web từ những vấn đề cơ bản nhất", 6L, 700000.0, "Nhập môn lập trình Web", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9083), "bắt đầu lập trình Web từ những vấn đề cơ bản nhất", 0, 1, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate", "DetailDescription", "SortOrder", "TeacherId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 5L, "Khóa học tiếng Trung dễ hiểu, lôi cuốn cho người mới bắt đầu, được thiết kế dựa trên giáo trình Boya Chinese của Đại học Văn hóa và Ngôn ngữ Bắc Kinh.", 7L, 599000.0, "Tiếng Trung cơ bản", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9090), "Khóa học tiếng Trung dễ hiểu, lôi cuốn cho người mới bắt đầu, được thiết kế dựa trên giáo trình Boya Chinese của Đại học Văn hóa và Ngôn ngữ Bắc Kinh.", 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9091) },
                    { 4L, "Trọn bộ kỹ năng tiếng anh cơ bản. Giao tiếp tiếng Anh từ con số 0.", 8L, 499000.0, "Tiếng Anh cho người bắt đầu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9087), "Trọn bộ kỹ năng tiếng anh cơ bản. Giao tiếp tiếng Anh từ con số 0.", 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9088) }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate", "DetailDescription", "SortOrder", "Status", "TeacherId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 6L, "Khóa học này sẽ giúp bạn làm quen với tiếng Nhật và có kiến thức nền tảng.", 9L, 666000.0, "Tiếng Nhật cơ bản cho người bắt đầu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9093), "Khóa học này sẽ giúp bạn làm quen với tiếng Nhật và có kiến thức nền tảng.", 0, 1, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate", "DetailDescription", "SortOrder", "TeacherId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 7L, "Trở thành nhà thiết kế chuyên nghiệp với Photoshop", 10L, 299000.0, "Học Photoshop trọn bộ", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9097), "Trở thành nhà thiết kế chuyên nghiệp với Photoshop.", 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate", "DetailDescription", "SortOrder", "Status", "TeacherId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 8L, "Học thiết kế đồ họa với Adobe CC trong khóa học mới này!", 11L, 499000.0, "Học thiết kế đồ họa trọn bộ", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9100), "Học thiết kế đồ họa với Adobe CC trong khóa học mới này!", 0, 1, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9101) });

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
                    { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(1041), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(1287), null },
                    { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2359), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2385), null },
                    { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2459), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2460), null },
                    { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2465), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2466), null },
                    { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2462), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2463), null }
                });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "Content", "CourseId", "CreatedBy", "CreatedDate", "Rate", "StudentId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1L, "Tạm được", 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(4263), 7, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "Content", "CourseId", "CreatedBy", "CreatedDate", "Rate", "StudentId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 2L, "Khóa học rất tốt", 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(5273), 9, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "Content", "CourseId", "CreatedBy", "CreatedDate", "Rate", "StudentId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3L, "Khóa học rất bổ ích", 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(5308), 8, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryId",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CreatedBy",
                table: "Category",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Category_UpdatedBy",
                table: "Category",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Course_CategoryId",
                table: "Course",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_TeacherId",
                table: "Course",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseDetail_CourseId",
                table: "CourseDetail",
                column: "CourseId");

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
                name: "CourseDetail");

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
