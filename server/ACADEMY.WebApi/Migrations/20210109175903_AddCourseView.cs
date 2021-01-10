using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.WebApi.Migrations
{
    public partial class AddCourseView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "UpdatedDate",
                "StudentCourse",
                "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDate",
                "StudentCourse",
                "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                "NumOfView",
                "Course",
                "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                1L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 997, DateTimeKind.Local).AddTicks(9567),
                    new DateTime(2021, 1, 10, 0, 59, 2, 998, DateTimeKind.Local).AddTicks(8927)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                2L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 998, DateTimeKind.Local).AddTicks(9994),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(17)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                3L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(42),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(43)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                4L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(352),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(357)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                5L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(372),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(373)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                6L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(375),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(376)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                7L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(378),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(379)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                8L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(384),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(385)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                9L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(387),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(388)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                10L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(390),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(391)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                11L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(393),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(394)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                12L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(396),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(397)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                1L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(3495),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(3778)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                2L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4667),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4683)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                3L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4709),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4710)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                4L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4713),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4714)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                5L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4715),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4716)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                6L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4718),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4719)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                7L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4722),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4723)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                8L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4725),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(4726)
                });

            migrationBuilder.UpdateData(
                "Feedback",
                "Id",
                1L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 3, 0, DateTimeKind.Local).AddTicks(307),
                    new DateTime(2021, 1, 10, 0, 59, 3, 0, DateTimeKind.Local).AddTicks(563)
                });

            migrationBuilder.UpdateData(
                "Feedback",
                "Id",
                2L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 3, 0, DateTimeKind.Local).AddTicks(1546),
                    new DateTime(2021, 1, 10, 0, 59, 3, 0, DateTimeKind.Local).AddTicks(1795)
                });

            migrationBuilder.UpdateData(
                "Feedback",
                "Id",
                3L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 3, 0, DateTimeKind.Local).AddTicks(1821),
                    new DateTime(2021, 1, 10, 0, 59, 3, 0, DateTimeKind.Local).AddTicks(1823)
                });

            migrationBuilder.UpdateData(
                "Role",
                "Id",
                new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                "ConcurrencyStamp",
                "68a937dc-2f9e-4f9c-b8bd-cf2312e9f408");

            migrationBuilder.UpdateData(
                "Role",
                "Id",
                new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                "ConcurrencyStamp",
                "a334a613-cd15-44be-a166-b32e7f104501");

            migrationBuilder.UpdateData(
                "Role",
                "Id",
                new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                "ConcurrencyStamp",
                "e42b6428-5cc5-44a9-878b-8e9a03d4518a");

            migrationBuilder.UpdateData(
                "User",
                "Id",
                new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                "PasswordHash",
                "AQAAAAEAACcQAAAAEJcmrwd8Z5cAQ/ImTEzNlRqXukiD2rEkyhaLx3ScO8agEfN9/epMaVMNehul/bWfGg==");

            migrationBuilder.UpdateData(
                "User",
                "Id",
                new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                "PasswordHash",
                "AQAAAAEAACcQAAAAEB1Z0ODzrIGFqDlgGcwyBqpz4dnwZ6ukMhd01UTMv9LBuDeQmWxsUcXszgW0sOK0BA==");

            migrationBuilder.UpdateData(
                "User",
                "Id",
                new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                "PasswordHash",
                "AQAAAAEAACcQAAAAEIWqoIxGgD7lrajTMW/AFABQNxg2XtGx3WfNapEZIsXiVOEKngbPyIe3Pq6KQACrnA==");

            migrationBuilder.UpdateData(
                "User",
                "Id",
                new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                "PasswordHash",
                "AQAAAAEAACcQAAAAEJM1bbcenmVCc1FGs6DJwaEgXdHF7byDfjQgPWAOWuqlW1ufCptNvMDuNN6EJllaCw==");

            migrationBuilder.UpdateData(
                "User",
                "Id",
                new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                "PasswordHash",
                "AQAAAAEAACcQAAAAEHBBlGIUCAfDnVQsvOBAs47ZT9zsvXifQQVbMfCtYNN1/plFVL3svGBxzKga9fR/oA==");

            migrationBuilder.UpdateData(
                "User",
                "Id",
                new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                "PasswordHash",
                "AQAAAAEAACcQAAAAEPHrJdXZMjZIRjwvZIhKh1djM8E7wqGZP7ug3rvp56qXVsPpUlJwg5s93KsLflIs8Q==");

            migrationBuilder.UpdateData(
                "WatchList",
                "Id",
                1L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(7788),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8052)
                });

            migrationBuilder.UpdateData(
                "WatchList",
                "Id",
                2L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8843),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8869)
                });

            migrationBuilder.UpdateData(
                "WatchList",
                "Id",
                3L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8892),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8893)
                });

            migrationBuilder.UpdateData(
                "WatchList",
                "Id",
                4L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8895),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8896)
                });

            migrationBuilder.UpdateData(
                "WatchList",
                "Id",
                5L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8897),
                    new DateTime(2021, 1, 10, 0, 59, 2, 999, DateTimeKind.Local).AddTicks(8898)
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "NumOfView",
                "Course");

            migrationBuilder.AlterColumn<DateTime>(
                "UpdatedDate",
                "StudentCourse",
                "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                "CreatedDate",
                "StudentCourse",
                "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                1L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 354, DateTimeKind.Local).AddTicks(355),
                    new DateTime(2021, 1, 7, 13, 48, 57, 354, DateTimeKind.Local).AddTicks(9352)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                2L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(355),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(376)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                3L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(399),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(400)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                4L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(700),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(706)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                5L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(721),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(723)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                6L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(724),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(726)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                7L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(727),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(728)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                8L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(730),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(731)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                9L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(733),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(734)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                10L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(736),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(737)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                11L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(738),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(739)
                });

            migrationBuilder.UpdateData(
                "Category",
                "Id",
                12L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(741),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(742)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                1L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(3054),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(3312)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                2L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4116),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4128)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                3L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4151),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4152)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                4L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4154),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4155)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                5L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4157),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4158)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                6L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4161),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4162)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                7L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4164),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4165)
                });

            migrationBuilder.UpdateData(
                "Course",
                "Id",
                8L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4167),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(4168)
                });

            migrationBuilder.UpdateData(
                "Feedback",
                "Id",
                1L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(8840),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9082)
                });

            migrationBuilder.UpdateData(
                "Feedback",
                "Id",
                2L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9830),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9841)
                });

            migrationBuilder.UpdateData(
                "Feedback",
                "Id",
                3L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9862),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(9863)
                });

            migrationBuilder.UpdateData(
                "Role",
                "Id",
                new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                "ConcurrencyStamp",
                "435d1685-796b-4c32-9fbc-5e5d85c5dd5e");

            migrationBuilder.UpdateData(
                "Role",
                "Id",
                new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                "ConcurrencyStamp",
                "429bd273-6714-4505-bccf-98cac6eadbcd");

            migrationBuilder.UpdateData(
                "Role",
                "Id",
                new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                "ConcurrencyStamp",
                "d71c0a31-a676-4f2c-8bba-a05585021292");

            migrationBuilder.UpdateData(
                "User",
                "Id",
                new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                "PasswordHash",
                "AQAAAAEAACcQAAAAEMTRA0FSAqHjSTR62jwwthpGsaAcQg59tWEHppZZ9TTENOdrnOnliyY06r3r3AtFSw==");

            migrationBuilder.UpdateData(
                "User",
                "Id",
                new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                "PasswordHash",
                "AQAAAAEAACcQAAAAEIihu2I4JHpX1YeB+L40fEkKA6Uw0bF7/BT8SSviIRzu6MksIteVopV83AD0Xmgmvg==");

            migrationBuilder.UpdateData(
                "User",
                "Id",
                new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                "PasswordHash",
                "AQAAAAEAACcQAAAAEN0cPrt6j5lRyseMdq2JSTL8NHD9fV+8uZ+cis8y/J8zC2sMybge2l7/NGtd2q5x/A==");

            migrationBuilder.UpdateData(
                "User",
                "Id",
                new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                "PasswordHash",
                "AQAAAAEAACcQAAAAEGqgxhQB2PiRt444cV0SYWp8Yox6HOOrW5AEfmsw5NIw+RV6eEXF5hw6UMdoB/ei1Q==");

            migrationBuilder.UpdateData(
                "User",
                "Id",
                new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                "PasswordHash",
                "AQAAAAEAACcQAAAAENpdgbSXXDF+NERR1v0H5HXuEl4JbnygUythf6uENHkSZemt/6gujhiC56EeU/CpbQ==");

            migrationBuilder.UpdateData(
                "User",
                "Id",
                new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                "PasswordHash",
                "AQAAAAEAACcQAAAAEFZiQe6mz1zkJ5UUdShlNaeKGqeBh4c+2iWMoL6R2w0Yn1NS/GyhlBnaRiAdP5pjqg==");

            migrationBuilder.UpdateData(
                "WatchList",
                "Id",
                1L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(6192),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(6456)
                });

            migrationBuilder.UpdateData(
                "WatchList",
                "Id",
                2L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7407),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7433)
                });

            migrationBuilder.UpdateData(
                "WatchList",
                "Id",
                3L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7452),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7454)
                });

            migrationBuilder.UpdateData(
                "WatchList",
                "Id",
                4L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7455),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7456)
                });

            migrationBuilder.UpdateData(
                "WatchList",
                "Id",
                5L,
                new[] {"CreatedDate", "UpdatedDate"},
                new object[]
                {
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7458),
                    new DateTime(2021, 1, 7, 13, 48, 57, 355, DateTimeKind.Local).AddTicks(7459)
                });
        }
    }
}