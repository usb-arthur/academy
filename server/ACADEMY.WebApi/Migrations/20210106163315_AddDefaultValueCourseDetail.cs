using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.WebApi.Migrations
{
    public partial class AddDefaultValueCourseDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsReview",
                table: "CourseDetail",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "CourseDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleDate",
                table: "Course",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<double>(
                name: "Sale",
                table: "Course",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

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
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(4280), null, null, new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5450), null, null, new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5488), null, null, new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5491), null, null, new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5494), null, null, new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5497), null, null, new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5500), null, null, new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5503), null, null, new DateTime(2021, 1, 6, 23, 33, 14, 469, DateTimeKind.Local).AddTicks(5504) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsReview",
                table: "CourseDetail",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "CourseDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Sale",
                table: "Course",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 2, DateTimeKind.Local).AddTicks(9314), new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9549), new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9602), new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9908), new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9931), new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9934), new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9937), new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9940), new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9942), new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9945), new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9948), new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9951), new DateTime(2021, 1, 6, 23, 10, 30, 3, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(2358), 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3568), 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3603), 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3606), 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3609), 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3612), 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3614), 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "Sale", "SaleDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3617), 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(8185), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(9186), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(9219), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                column: "ConcurrencyStamp",
                value: "acddb1dd-8eb6-4eae-bc59-b351ccd3d6f8");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                column: "ConcurrencyStamp",
                value: "f3a09cd2-2f0c-4c3c-9f61-d4257a904b71");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                column: "ConcurrencyStamp",
                value: "62503d60-c468-4cbd-9194-4d1a385d22ef");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEObRQ6uaPxLOYvWtJn7jCph+DW//Dh2j8HBG+Pk9fxcifOnZmUR6xS/xzik/n8UEjg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIbNKs5JRpAJC+p/9GApjVcrMfcJ1foq76N+mA2K08iqveio5Enz67BS93YKFefanA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENeGudjlF8vsr6oabac36xvXFKv6gZlTHajfPxkm2PJOPAoyARUAUJ5ArjcULgO+hQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGNIC3OO3F75n+2XQT951XxowTZcQd0gHApOMDSCy3lB/cbDnhPB49CErdhHDIFw/w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBpgCMluGwjKIARj+89bRFDIvrt3gHSQtDNxg8/NOhxk/8C3KULsqnhrwZJ2pw3/ow==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELaEEvZLetrb8bDYwIKqP61tpVlMGBupRdUsZjj/7qK2wVTZdXNCUbFfA8RRq+LYBA==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(5727), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(6736), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(6790), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(6793), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(6796), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(6797) });
        }
    }
}
