using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.Data.EF.Migrations
{
    public partial class AddRefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

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
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDftPwbBR/y+NnFngFJRzfzPAQS0RLs9F9nLa2p0OkYOZRmIwFf6E2FlLgvAD4GrPw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGYcjzYHOFjLF0xMfIaNJOMo5wKPJ/9gVq/onUVpKLO+64S6j3WOHpb7id/PbZy94w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHzDcayT2AQAL3rJDKAvafV+4rpPlabdeh6yIUV+oxLbqYkRAxzVowPBJkPqydrSWw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIMdO+eRb0RziS/q4h/iCS6YGyNAuEbjEAfI6kggfZL+MpUyzd3qsn+psH3wZy/6Ug==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAED6iq7xkASHhvotNEqEZGPZA521wuIDM3nDZvb8aPdK7MzwrqwF16UW7I4QaLbb46g==");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "User");

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
    }
}
