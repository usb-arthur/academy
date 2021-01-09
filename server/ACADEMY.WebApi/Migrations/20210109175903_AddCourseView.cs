using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.WebApi.Migrations
{
    public partial class AddCourseView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "StudentCourse",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StudentCourse",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "NumOfView",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumOfView",
                table: "Course");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "StudentCourse",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StudentCourse",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 354, DateTimeKind.Local).AddTicks(355), new DateTime(2021, 1, 7, 13, 48, 57, 354, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(355), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(399), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(700), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(721), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(724), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(727), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(730), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(733), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(736), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(738), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(741), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(3054), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4116), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4151), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4154), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4157), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4161), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4164), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4167), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(8840), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9830), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9862), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                column: "ConcurrencyStamp",
                value: "435d1685-796b-4c32-9fbc-5e5d85c5dd5e");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                column: "ConcurrencyStamp",
                value: "429bd273-6714-4505-bccf-98cac6eadbcd");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                column: "ConcurrencyStamp",
                value: "d71c0a31-a676-4f2c-8bba-a05585021292");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMTRA0FSAqHjSTR62jwwthpGsaAcQg59tWEHppZZ9TTENOdrnOnliyY06r3r3AtFSw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIihu2I4JHpX1YeB+L40fEkKA6Uw0bF7/BT8SSviIRzu6MksIteVopV83AD0Xmgmvg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEN0cPrt6j5lRyseMdq2JSTL8NHD9fV+8uZ+cis8y/J8zC2sMybge2l7/NGtd2q5x/A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGqgxhQB2PiRt444cV0SYWp8Yox6HOOrW5AEfmsw5NIw+RV6eEXF5hw6UMdoB/ei1Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENpdgbSXXDF+NERR1v0H5HXuEl4JbnygUythf6uENHkSZemt/6gujhiC56EeU/CpbQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFZiQe6mz1zkJ5UUdShlNaeKGqeBh4c+2iWMoL6R2w0Yn1NS/GyhlBnaRiAdP5pjqg==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(6192), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7407), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7452), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7455), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7458), new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7459) });
        }
    }
}
