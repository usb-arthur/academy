using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.Data.EF.Migrations
{
    public partial class InitializeDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaim",
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
                    table.PrimaryKey("PK_AppRoleClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaim",
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
                    table.PrimaryKey("PK_AppUserClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
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
                    Status = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Role_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_User_UsersId",
                        column: x => x.UsersId,
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
                    { 1L, null, "Công nghệ thông tin", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 655, DateTimeKind.Local).AddTicks(4314), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(5892) },
                    { 2L, null, "Ngoại ngữ", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(7574), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(7590) },
                    { 3L, null, "Thiết kế", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(7631), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(7632) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Contact", "CreatedBy", "DateOfBirth", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1999, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NguyenVanHung@gmail.com", true, 0, false, null, "Nguyễn Văn Hùng", "NguyenVanHung@gmail.com", "Nguyễn Văn Hùng", "AQAAAAEAACcQAAAAEFkRR2tKITZwvXqBLVvEkgRq3TwLxapCSq5mqKItjv0nqo6Yhz1iwH97WrDeQC3FqA==", "0325874156", true, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Nguyễn Văn Hùng" },
                    { new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1998, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "TranVanQuang@gmail.com", true, 0, false, null, "Trần Văn Quang", "TranVanQuang@gmail.com", "Trần Văn Quang", "AQAAAAEAACcQAAAAEJWOmuepDeQax10bINVvP1ObrnDsun3kGWXw/1Xg8VjXGjMA4D/MekNBHuCruJd6pw==", "0325855156", true, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Trần Văn Quang" },
                    { new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2000, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "PhamThiNhung@gmail.com", true, 1, false, null, "Phạm Thị Nhung", "PhamThiNhung@gmail.com", "Phạm Thị Nhung", "AQAAAAEAACcQAAAAEDMJhmCXS9u4LpDRq6ryd628Zc2sejQscC89Qy6iIiNi254iToz/ljkRFQnyp+wPTw==", "0326675156", true, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Phạm Thị Nhung" },
                    { new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2002, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "PhanThiThuy@gmail.com", true, 1, false, null, "Phan Thị Thủy", "PhanThiThuy@gmail.com", "Phan Thị Thủy", "AQAAAAEAACcQAAAAEIV42aDNSXCBTCzmZalTgnghyUWtk+3GUZwSxdEPl966jXwkxDSnZ5tF31K+7kObRg==", "0326675233", true, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Phan Thị Thủy" },
                    { new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"), 1, "", "email, message, phone", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "HoQuangPhu@gmail.com", true, 0, false, null, "Hồ Quang Phú", "HoQuangPhu@gmail.com", "Hồ Quang Phú", "AQAAAAEAACcQAAAAEFP+y8R66X5egUY5AuDZ5biwG1iHT5BjgiqLThCIvZW/qA6n9cMB9qPjNEjA84ZlKQ==", "0326676666", true, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "Hồ Quang Phú" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 4L, 1L, "Cơ sở dữ liệu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8142), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8147) },
                    { 5L, 1L, "Ngôn ngữ lập trình", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8165), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8166) },
                    { 6L, 1L, "Lập trình web", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8168), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8169) },
                    { 7L, 2L, "Tiếng Hoa", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8171), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8175) },
                    { 8L, 2L, "Tiếng Anh", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8176), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8177) },
                    { 9L, 2L, "Tiếng Nhật", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8180), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8181) },
                    { 10L, 3L, "Phần mềm thiết kế", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8183), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8184) },
                    { 11L, 3L, "Thiết kế đồ họa", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8185), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8186) },
                    { 12L, 3L, "Thiết kế 3D", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8188), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8189) }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "BriefDescription", "CategoryId", "CourseFee", "CourseName", "CreatedBy", "CreatedDate", "DetailDescription", "IsDeleted", "SortOrder", "Status", "TeacherId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, "Khóa học này sẽ giúp các lập trình viên nắm được nguyên tắc, cú pháp và cách thức hoạt động của SQL (Structured Query Language).", 4L, 500000.0, "Làm quen với SQL", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(2283), "Khóa học này sẽ giúp các lập trình viên nắm được nguyên tắc, cú pháp và cách thức hoạt động của SQL (Structured Query Language).", false, 0, 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(2780) },
                    { 2L, "Khóa học lập trình C cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản và là nền tảng để bạn đi xa hơn trên con đường lập trình.", 5L, 499000.0, "C cho người mới bắt đầu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4219), "Khóa học lập trình C cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản và là nền tảng để bạn đi xa hơn trên con đường lập trình.", false, 0, 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4231) },
                    { 3L, "bắt đầu lập trình Web từ những vấn đề cơ bản nhất", 6L, 700000.0, "Nhập môn lập trình Web", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4254), "bắt đầu lập trình Web từ những vấn đề cơ bản nhất", false, 0, 1, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4255) },
                    { 5L, "Khóa học tiếng Trung dễ hiểu, lôi cuốn cho người mới bắt đầu, được thiết kế dựa trên giáo trình Boya Chinese của Đại học Văn hóa và Ngôn ngữ Bắc Kinh.", 7L, 599000.0, "Tiếng Trung cơ bản", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4260), "Khóa học tiếng Trung dễ hiểu, lôi cuốn cho người mới bắt đầu, được thiết kế dựa trên giáo trình Boya Chinese của Đại học Văn hóa và Ngôn ngữ Bắc Kinh.", false, 0, 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4262) },
                    { 4L, "Trọn bộ kỹ năng tiếng anh cơ bản. Giao tiếp tiếng Anh từ con số 0.", 8L, 499000.0, "Tiếng Anh cho người bắt đầu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4258), "Trọn bộ kỹ năng tiếng anh cơ bản. Giao tiếp tiếng Anh từ con số 0.", false, 0, 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4259) },
                    { 6L, "Khóa học này sẽ giúp bạn làm quen với tiếng Nhật và có kiến thức nền tảng.", 9L, 666000.0, "Tiếng Nhật cơ bản cho người bắt đầu", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4264), "Khóa học này sẽ giúp bạn làm quen với tiếng Nhật và có kiến thức nền tảng.", false, 0, 1, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4265) },
                    { 7L, "Trở thành nhà thiết kế chuyên nghiệp với Photoshop", 10L, 299000.0, "Học Photoshop trọn bộ", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4267), "Trở thành nhà thiết kế chuyên nghiệp với Photoshop.", false, 0, 0, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4268) },
                    { 8L, "Học thiết kế đồ họa với Adobe CC trong khóa học mới này!", 11L, 499000.0, "Học thiết kế đồ họa trọn bộ", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4330), "Học thiết kế đồ họa với Adobe CC trong khóa học mới này!", false, 0, 1, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4331) }
                });

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
                    { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(7621), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(8080), null },
                    { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9471), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9482), null },
                    { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9518), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9519), null },
                    { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9523), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9524), null },
                    { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9520), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9521), null }
                });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "Content", "CourseId", "CreatedBy", "CreatedDate", "Rate", "StudentId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1L, "Tạm được", 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 658, DateTimeKind.Local).AddTicks(1876), 7, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 658, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "Content", "CourseId", "CreatedBy", "CreatedDate", "Rate", "StudentId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 2L, "Khóa học rất tốt", 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 658, DateTimeKind.Local).AddTicks(3735), 9, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 658, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "Content", "CourseId", "CreatedBy", "CreatedDate", "Rate", "StudentId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3L, "Khóa học rất bổ ích", 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 658, DateTimeKind.Local).AddTicks(3768), 8, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new DateTime(2020, 12, 13, 13, 7, 14, 658, DateTimeKind.Local).AddTicks(3770) });

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
                name: "IX_RoleUser_UsersId",
                table: "RoleUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchList_UserId",
                table: "WatchList",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaim");

            migrationBuilder.DropTable(
                name: "AppUserClaim");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "RoleUser");

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
                name: "Role");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
