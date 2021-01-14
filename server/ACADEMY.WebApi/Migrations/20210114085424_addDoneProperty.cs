using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.WebApi.Migrations
{
    public partial class addDoneProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Category_CategoryId",
                table: "Course");

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "CourseDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<long>(
                name: "CategoryId",
                table: "Course",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 579, DateTimeKind.Local).AddTicks(9124), new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9271), new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9319), new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9683), new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9703), new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9706), new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9709), new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9712), new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9714), new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9717), new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9720), new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9722), new DateTime(2021, 1, 14, 15, 54, 23, 580, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(2179), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3233), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3359), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3363), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3366), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3372), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3375), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3378), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(7776), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(9241), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(9281), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                column: "ConcurrencyStamp",
                value: "3c0cb6d6-6420-46a8-8923-08fe798ba001");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                column: "ConcurrencyStamp",
                value: "b33a61a6-e12a-4879-8c3e-bf8409cef1fb");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                column: "ConcurrencyStamp",
                value: "8eaed57d-a187-4413-af95-8c97d968fef7");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPYK0ERTGCMO9TK+xJIW/mNRmGfQolZwIM0fWfKCFX/m2TPFpULOzl6d3/N2xkzbYQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENz6VhHMrpnWq6G06HU5n2Ob3MTBjNt27hcJx8A9Gey+Krlu0XAONtXaDIf5PWv0qA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJTkj5FHu1uYOFTdslNFiDaI2i5cDzkFCGpZ7j4ejx4EOGZ2sIl/GZzbbRi3qqgGyA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFYE2hFYl2zZZoT/DifNiqFsaI3JasRXlQANrVFarCIg2o333xrvLhGzoLybhHK53A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKk19jRTtRNU9e7JGeTBBHmqTyyzVO8Qfpd5cwoyuXuN/q7sCNouVDZ7VlV6cByMXg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMV0U7dbn8Ro1AWAv7ZCquyc6tA+ULscI5byGedY5t9LGYci7sgc2ND6Nvh2UqIwUg==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(5381), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(6373), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(6427), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(6430), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(6432), new DateTime(2021, 1, 14, 15, 54, 23, 581, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Category_CategoryId",
                table: "Course",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Category_CategoryId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Done",
                table: "CourseDetail");

            migrationBuilder.AlterColumn<long>(
                name: "CategoryId",
                table: "Course",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Category_CategoryId",
                table: "Course",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
