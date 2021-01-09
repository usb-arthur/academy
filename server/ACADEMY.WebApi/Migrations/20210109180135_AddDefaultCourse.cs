using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.WebApi.Migrations
{
    public partial class AddDefaultCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumOfView",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 323, DateTimeKind.Local).AddTicks(2194), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(4888), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(4935), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5226), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5263), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5266), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5268), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5271), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5334), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5337), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5342), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5344), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(7566), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8580), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8613), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8616), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8620), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8622), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8625), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8629), new DateTime(2021, 1, 10, 1, 1, 34, 324, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(2942), new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(4597), new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(4629), new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                column: "ConcurrencyStamp",
                value: "7fd00c2e-945a-4209-9a7e-a0d9f7525a01");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                column: "ConcurrencyStamp",
                value: "3c636e66-7443-4c5d-9d7b-904256a10f4b");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                column: "ConcurrencyStamp",
                value: "3eeb5b7a-463a-41b1-ac7d-eef2b0af4c84");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEr3iwe/U3WJ/t0a+Hd/DOywIQYnZ6pqDLK4SILz+9d3li5mQdK7Us5iWjbKudjaQg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJEvZBZ5KYodQvIyFWAutiatpH74cc+6zM8430aZpmo+SxUeQLjlSMw2CsD5IOCYPA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEF6Dtcf+OoP0/Zqy4mIdR4K9vx7tCxSRNgFOb2yTW/7PUNeDiiMOILpE37oFI54DLA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBHd56REoWiwBlEwWcaBHuy/nKrVYgbZ3J/dE58KSyhZFqZHXC7fy+BSVRpFYtAqmw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHchBppQuzaytro6wgN+zfioh01Bcpz2ccmBIFps9+oxmdd8O2v1jLuo8uORTWvd8A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAMGTF3Xrwj/UdWqeDoZbCcCr2LidkUW+pWti5TTW+R70ZwRNRIn7aEhwO4GAfqGDg==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(461), new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(1578), new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(1643), new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(1646), new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(1648), new DateTime(2021, 1, 10, 1, 1, 34, 325, DateTimeKind.Local).AddTicks(1649) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumOfView",
                table: "Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 997, DateTimeKind.Local).AddTicks(9567), new DateTime(2021, 1, 10, 0, 59, 2, 998, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 998, DateTimeKind.Local).AddTicks(9994), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(42), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(352), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(372), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(375), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(378), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(384), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(387), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(390), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(393), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(396), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(3495), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4667), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4709), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4713), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4715), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4718), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4722), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4725), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 3, 0, DateTimeKind.Local).AddTicks(307), new DateTime(2021, 1, 10, 0, 59, 3, 0, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 3, 0, DateTimeKind.Local).AddTicks(1546), new DateTime(2021, 1, 10, 0, 59, 3, 0, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 3, 0, DateTimeKind.Local).AddTicks(1821), new DateTime(2021, 1, 10, 0, 59, 3, 0, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                column: "ConcurrencyStamp",
                value: "68a937dc-2f9e-4f9c-b8bd-cf2312e9f408");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                column: "ConcurrencyStamp",
                value: "a334a613-cd15-44be-a166-b32e7f104501");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                column: "ConcurrencyStamp",
                value: "e42b6428-5cc5-44a9-878b-8e9a03d4518a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJcmrwd8Z5cAQ/ImTEzNlRqXukiD2rEkyhaLx3ScO8agEfN9/epMaVMNehul/bWfGg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEB1Z0ODzrIGFqDlgGcwyBqpz4dnwZ6ukMhd01UTMv9LBuDeQmWxsUcXszgW0sOK0BA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIWqoIxGgD7lrajTMW/AFABQNxg2XtGx3WfNapEZIsXiVOEKngbPyIe3Pq6KQACrnA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJM1bbcenmVCc1FGs6DJwaEgXdHF7byDfjQgPWAOWuqlW1ufCptNvMDuNN6EJllaCw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHBBlGIUCAfDnVQsvOBAs47ZT9zsvXifQQVbMfCtYNN1/plFVL3svGBxzKga9fR/oA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPHrJdXZMjZIRjwvZIhKh1djM8E7wqGZP7ug3rvp56qXVsPpUlJwg5s93KsLflIs8Q==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(7788), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8843), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8892), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8895), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8897), new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8898) });
        }
    }
}
