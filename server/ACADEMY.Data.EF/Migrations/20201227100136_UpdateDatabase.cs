using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.Data.EF.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "UserRole",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 98, DateTimeKind.Local).AddTicks(1537), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(3823), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(3877), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4608), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4650), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4942), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4945), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4948), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4951), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4954), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4957), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4959), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(3147), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5155), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5195), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5200), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5203), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5206), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5209), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5212), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(4219), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(6018), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(6054), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"), "ffba2660-f30c-4541-ab9b-09b5e37c70fc", "Admin", "admin" },
                    { new Guid("85baa706-7544-477e-ba32-004d478a7200"), "67813ce3-ee5a-415c-bb4e-c8c156017087", "Student", "student" },
                    { new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"), "41d33816-1275-4503-8c66-ae7332122ab1", "Teacher", "teacher" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAEAACcQAAAAEHeWRC2Sa/N4DwKER4LV+KD5K68jgPs1XHWpQyli1DOAwfkGFSpBY7OAKQ9KmGBAqg==", "NguyenVanHung@gmail.com" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAEAACcQAAAAEEjptX+h0aq63G3UcXN6aI0sIxsEyhCIJlXe8x4fYiM2AUe0/jVGC0hwUEg3K8RkDQ==", "PhanThiThuy@gmail.com" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAEAACcQAAAAEKdXZCkHYgczPVy7AzmzhioZF+2drBQgLfL/hLpy9gmGiJjY8PHw5BURAJO0jniVbA==", "PhamThiNhung@gmail.com" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAEAACcQAAAAEOVnTOZOFix+XnaFK5JsSqmyTzMMt+OdlbbMF1crrGU4ybps5bErecodcqv03/nySA==", "TranVanQuang@gmail.com" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAEAACcQAAAAEK+Tu54WC98o5ieGpk1dQ2DqZIjbrpVyiGqeaZeVcrm2sOCV1sH1fWcL3ZgMFzisrg==", "HoQuangPhu@gmail.com" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Contact", "CreatedBy", "DateOfBirth", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedBy", "UserName" },
                values: new object[] { new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"), 1, "", "{'email': 'nhan.nguyenvo1@gmail.com'}", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1999, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "nhan.nguyenvo1@gmail.com", true, 0, false, null, "Nguyễn Võ Nhân", "nhan.nguyenvo1@gmail.com", "nhan.nguyenvo1@gmail.com", "AQAAAAEAACcQAAAAEDtjrAa3ca1byEm52mIRHxjI3NjwvgWU2v4FiLZe3481DIntXPpTgzvEM5LWPuQJ/g==", "0348310590", true, null, "", 1, false, new Guid("00000000-0000-0000-0000-000000000000"), "nhan.nguyenvo1@gmail.com" });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"), new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d") });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(9205), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1096), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1165), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1169), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1171), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1172) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85baa706-7544-477e-ba32-004d478a7200"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"));

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"), new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d") });

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "UserRole",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 535, DateTimeKind.Local).AddTicks(8165), new DateTime(2020, 12, 27, 15, 55, 7, 536, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(718), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(760), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1407), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1428), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1431), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1433), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1436), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1439), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1441), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1444), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1448), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(5807), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7623), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7658), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7661), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7664), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7667), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7671), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7674), new DateTime(2020, 12, 27, 15, 55, 7, 537, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(5244), new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(6963), new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(6996), new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAEAACcQAAAAEDftPwbBR/y+NnFngFJRzfzPAQS0RLs9F9nLa2p0OkYOZRmIwFf6E2FlLgvAD4GrPw==", "Nguyễn Văn Hùng" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAEAACcQAAAAEGYcjzYHOFjLF0xMfIaNJOMo5wKPJ/9gVq/onUVpKLO+64S6j3WOHpb7id/PbZy94w==", "Phan Thị Thủy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAEAACcQAAAAEHzDcayT2AQAL3rJDKAvafV+4rpPlabdeh6yIUV+oxLbqYkRAxzVowPBJkPqydrSWw==", "Phạm Thị Nhung" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAEAACcQAAAAEIMdO+eRb0RziS/q4h/iCS6YGyNAuEbjEAfI6kggfZL+MpUyzd3qsn+psH3wZy/6Ug==", "Trần Văn Quang" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAEAACcQAAAAED6iq7xkASHhvotNEqEZGPZA521wuIDM3nDZvb8aPdK7MzwrqwF16UW7I4QaLbb46g==", "Hồ Quang Phú" });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(1208), new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(2938), new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(2987), new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(2990), new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(2992), new DateTime(2020, 12, 27, 15, 55, 7, 538, DateTimeKind.Local).AddTicks(2993) });
        }
    }
}
