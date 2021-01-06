using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.WebApi.Migrations
{
    public partial class AddIdentityColumnCourseDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 972, DateTimeKind.Local).AddTicks(3256), new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(6937), new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7165), new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7653), new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7680), new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7684), new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7689), new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7694), new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7698), new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7702), new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7707), new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7711), new DateTime(2021, 1, 6, 23, 59, 32, 973, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(1413), new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3714), new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3771), new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3777), new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3782), new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3786), new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3790), new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3794), new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 975, DateTimeKind.Local).AddTicks(1198), new DateTime(2021, 1, 6, 23, 59, 32, 975, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 975, DateTimeKind.Local).AddTicks(3502), new DateTime(2021, 1, 6, 23, 59, 32, 975, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 975, DateTimeKind.Local).AddTicks(3560), new DateTime(2021, 1, 6, 23, 59, 32, 975, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                column: "ConcurrencyStamp",
                value: "94b2a516-4194-4c9e-9116-529502200f6a");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                column: "ConcurrencyStamp",
                value: "82c120db-840b-424b-bc21-af42880da3d9");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                column: "ConcurrencyStamp",
                value: "7e4c892e-f8b7-4571-b533-89d7d162fcdc");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEF/RiBFSkk5137fy+AczrrBqkWHbX2+75bK5Q/HRjmbSF0F453jWUGvFcBVTh1nGxA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOUx3a/JE54EWz9fenfktozPc/309YRTBUZ23ybBdgRXt2XGwQL2fz8smPg183UAZQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIcSwt7N9B6dEFn4gTRra6QxFyNwmL2B4Vs5Hj94rgu6Zw3Rckj8BEQudG5rPUTHgQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOhksB4kdkKnA6URq6EI11GDH4yDp/St2Oyooqafl0f+4gCyXaDiuNHvDsBNEE1VEg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECCyOQTAb9T2F+5v5roCxc227h4W1XpSWM5VhQ/btMLAK2r/BO36hLeaDwYe4gjHRQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENz0+0LYuXurA8LjrYsHK+0I0AtQPiN+OWFikydAdzkcZ773cZ5ajt+y0/tERSjdFw==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(6971), new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(8829), new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(8900), new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(8904), new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(8907), new DateTime(2021, 1, 6, 23, 59, 32, 974, DateTimeKind.Local).AddTicks(8908) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 710, DateTimeKind.Local).AddTicks(8249), new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8308), new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8350), new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8657), new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8678), new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8681), new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8684), new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8687), new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8689), new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8692), new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8695), new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8698), new DateTime(2021, 1, 6, 23, 37, 9, 711, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(1116), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2180), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2212), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2216), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2218), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2221), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2224), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2227), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(6534), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(8052), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(8086), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                column: "ConcurrencyStamp",
                value: "6fa68f1a-4029-49ed-9c6f-d9dcf61e964c");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                column: "ConcurrencyStamp",
                value: "65d6bc4b-b3ca-4189-8b3b-0a422a541b4f");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                column: "ConcurrencyStamp",
                value: "9f22acab-ca6b-424d-a9d2-b1bcc6455166");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMz41HRdIeczQ/vWWmWKQzOQGjY/PMV1Rp3U+5Y2MFk+03LQNIPRN+iH22bdO6ZAkQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECObQ+nuxD6NiyMah7Bat7K6ZxAFhuPxDAzxTNuen/ErzjRBu7qFRdynQJFcOT6sBg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEL/k6AHvvAa/YJAfXt/+dIwO06zls/VwQ13YB96bVfzPjJNtOtw76WxFinCQdb1DnA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDXSt6S0pa8r3H/mD53/RTrmX026qug+2XIIYUrAuq1oZ4wZsiTkZmJfeFu2gYSHGA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAzJ72JlHDi8O5+5rONwtFP9N5oP2G/Q5M/+CxjitD6hjSUYxhutnQ85QCwMYEDJIg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEApuHL/1zNvmFf9pA55peszNJQm6IrRkbUexh+UF80HTa2XOtKHnQAf8qX4x5pglhg==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(4144), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(5128), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(5177), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(5180), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(5182), new DateTime(2021, 1, 6, 23, 37, 9, 712, DateTimeKind.Local).AddTicks(5183) });
        }
    }
}
