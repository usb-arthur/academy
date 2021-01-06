using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.WebApi.Migrations
{
    public partial class RemoveCourseUrlCourseDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseUrl",
                table: "CourseDetail");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 283, DateTimeKind.Local).AddTicks(1256), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1566), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1615), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1925), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1948), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1951), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1954), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1957), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1961), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1964), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1967), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1970), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(4502), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5840), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5879), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5883), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5886), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5889), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5892), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5895), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 285, DateTimeKind.Local).AddTicks(986), new DateTime(2021, 1, 7, 0, 9, 49, 285, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 285, DateTimeKind.Local).AddTicks(2061), new DateTime(2021, 1, 7, 0, 9, 49, 285, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 285, DateTimeKind.Local).AddTicks(2095), new DateTime(2021, 1, 7, 0, 9, 49, 285, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                column: "ConcurrencyStamp",
                value: "a3ff7aeb-ed59-4715-9c2a-7f75857335e6");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                column: "ConcurrencyStamp",
                value: "392c9889-38b4-4e0a-a853-66dbcbd19a49");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                column: "ConcurrencyStamp",
                value: "c0cc38d7-869b-45a7-b485-7a751ca400b3");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKLkJoao4aEhgCrbBB/8g3uubJ5kOb05s968JCu64YkFj9h3HsHPOqyVAtRUSxJwLw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEXBYrBlxVabojnnyYv3PWtKwFr8JG4yz3c0LIqyOKeLttPCSKkJLqn4Ko+LJLmsSg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEI+PLg23KnLxTBvRo4EgYaG4pT2x5bj0u8nxn+RA18jf+W6MkHsnHqHFaKyVHy+Sjw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGlInQqHBQQVTuqYdlvAxV1ZcJHb/IRE1ngQxQUIQ8K4vImRazVH5CwP5fW7xZqWCg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEwYz67kYJJc89fRVPWiDMVQ/H4iiKT3s/pGk+GGMVTG2121Hf4xRj9hhl+6OyjNwA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOs0Ex8yISd3Wc63j4Z67WtNSbMFjOB3/DLBf+tERzGVQO/fk5qTsY+y/JoqiXH0jg==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(8124), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(9437), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(9498), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(9501), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(9504), new DateTime(2021, 1, 7, 0, 9, 49, 284, DateTimeKind.Local).AddTicks(9505) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseUrl",
                table: "CourseDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
