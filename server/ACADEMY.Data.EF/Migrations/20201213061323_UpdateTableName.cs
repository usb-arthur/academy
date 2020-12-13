using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.Data.EF.Migrations
{
    public partial class UpdateTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserClaim",
                table: "AppUserClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoleClaim",
                table: "AppRoleClaim");

            migrationBuilder.RenameTable(
                name: "AppUserClaim",
                newName: "UserClaim");

            migrationBuilder.RenameTable(
                name: "AppRoleClaim",
                newName: "RoleClaim");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaim",
                table: "UserClaim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaim",
                table: "RoleClaim",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 70, DateTimeKind.Local).AddTicks(3785), new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4242), new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4285), new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4803), new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4827), new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4831), new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4833), new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4836), new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4839), new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4842), new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4845), new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4848), new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(9054), new DateTime(2020, 12, 13, 13, 13, 22, 71, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1007), new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1043), new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1047), new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1050), new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1053), new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1057), new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1061), new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(8721), new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 73, DateTimeKind.Local).AddTicks(553), new DateTime(2020, 12, 13, 13, 13, 22, 73, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 73, DateTimeKind.Local).AddTicks(585), new DateTime(2020, 12, 13, 13, 13, 22, 73, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKN4plO+RWtHO3qhDRgmKw9nHkkLZHF742pe4HTX8YX1gjfZ52WEfXCV6hZMxULwow==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDHsyJYxjJDNgpsqNumHyoQM35AfbTcuNbfAZNqVWPBSTr2I6EAu2fqcfPM3QoHnXA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGfnabhC5YUTccWms5JRknDPc/hY1q4hOnaZ0XahhePBRdJyFkolWNvrfkfEKaUa0Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEArlnEg176SaX1iTcjQ8Ghgd6mySpcYu/18chsSUs4z1rILYAzwQ76HI46BuVP6h7w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOZqr/fSGo1Q/z2iXAthT4b2S3yNH4D84pwQuDXV2FFi1xIW4ZkdAOCuyRzFOG4AEw==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(4326), new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(6162), new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(6219), new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(6223), new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(6225), new DateTime(2020, 12, 13, 13, 13, 22, 72, DateTimeKind.Local).AddTicks(6226) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaim",
                table: "UserClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaim",
                table: "RoleClaim");

            migrationBuilder.RenameTable(
                name: "UserClaim",
                newName: "AppUserClaim");

            migrationBuilder.RenameTable(
                name: "RoleClaim",
                newName: "AppRoleClaim");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserClaim",
                table: "AppUserClaim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoleClaim",
                table: "AppRoleClaim",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 655, DateTimeKind.Local).AddTicks(4314), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(7574), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(7631), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8142), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8165), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8168), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8171), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8176), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8180), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8183), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8185), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8188), new DateTime(2020, 12, 13, 13, 7, 14, 656, DateTimeKind.Local).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(2283), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4219), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4254), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4258), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4260), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4264), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4267), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4330), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 658, DateTimeKind.Local).AddTicks(1876), new DateTime(2020, 12, 13, 13, 7, 14, 658, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 658, DateTimeKind.Local).AddTicks(3735), new DateTime(2020, 12, 13, 13, 7, 14, 658, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 658, DateTimeKind.Local).AddTicks(3768), new DateTime(2020, 12, 13, 13, 7, 14, 658, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFkRR2tKITZwvXqBLVvEkgRq3TwLxapCSq5mqKItjv0nqo6Yhz1iwH97WrDeQC3FqA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIV42aDNSXCBTCzmZalTgnghyUWtk+3GUZwSxdEPl966jXwkxDSnZ5tF31K+7kObRg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDMJhmCXS9u4LpDRq6ryd628Zc2sejQscC89Qy6iIiNi254iToz/ljkRFQnyp+wPTw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJWOmuepDeQax10bINVvP1ObrnDsun3kGWXw/1Xg8VjXGjMA4D/MekNBHuCruJd6pw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFP+y8R66X5egUY5AuDZ5biwG1iHT5BjgiqLThCIvZW/qA6n9cMB9qPjNEjA84ZlKQ==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(7621), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9471), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9518), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9520), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9523), new DateTime(2020, 12, 13, 13, 7, 14, 657, DateTimeKind.Local).AddTicks(9524) });
        }
    }
}
