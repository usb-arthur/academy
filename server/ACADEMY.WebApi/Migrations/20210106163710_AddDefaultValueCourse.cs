using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.WebApi.Migrations
{
    public partial class AddDefaultValueCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Sale",
                table: "Course",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Sale",
                table: "Course",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 468, DateTimeKind.Local).AddTicks(1736), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1472), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1517), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1827), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1847), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1850), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1908), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1912), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1915), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1918), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1922), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1926), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(4280), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5450), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5488), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5491), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5494), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5497), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5500), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5503), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(9731), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 470, DateTimeKind.Local).AddTicks(661), new DateTime(2021, 1, 6, 23, 33, 14, 470, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 470, DateTimeKind.Local).AddTicks(693), new DateTime(2021, 1, 6, 23, 33, 14, 470, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                column: "ConcurrencyStamp",
                value: "79188cb3-5051-4446-b439-00661167e1fc");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                column: "ConcurrencyStamp",
                value: "0bc02a36-6693-4adc-b932-0d7eea832d9a");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                column: "ConcurrencyStamp",
                value: "f58009c2-ad15-4357-9f81-7eae71832dd9");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPNirya98GYoF7WDot4q8kD2KlLRmwJBz3oonU5Z65iS62fxNDJp62Dwbrxa+xqjQg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFiUuEND7187zmAvD2UupRXBiDsmBtPlBoW98lvuLN7XHvKK3t8LvAQgTZQc8nQeVg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKefwlYRinKYD448HGL95eZtvqJ7Tt6sQbSp9Kjbz3HiNGOp/GY99SyP2C+/meW2/A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKB+bR2RqqS8affCtegyuHv9IiNZfSQgsWu3Omv0bespR54TXzuet8eJ7dIR66a1AA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELJSuulWgH2LlOgHu2bB5TuR2IhSjBCg2kWey+j9Lx08SHSbfvHpT3rvfIboJgyCyA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEE0Aub36mSx6nZT58mkJvpnWwjBbJIp0F0PoRO+jQ+EFLPrK/THA2B8zBTX1V7t+7g==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(7360), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(8376), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(8423), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(8426), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(8428), new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(8429) });
        }
    }
}
