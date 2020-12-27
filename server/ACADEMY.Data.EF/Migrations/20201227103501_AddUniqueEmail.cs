using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.Data.EF.Migrations
{
    public partial class AddUniqueEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 154, DateTimeKind.Local).AddTicks(8342), new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(8473), new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(8520), new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9024), new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9048), new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9051), new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9055), new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9058), new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9061), new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9064), new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9067), new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9121), new DateTime(2020, 12, 27, 17, 35, 0, 155, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(3326), new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5154), new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5187), new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5191), new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5195), new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5199), new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5201), new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5204), new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(2830), new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(4569), new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(4602), new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                column: "ConcurrencyStamp",
                value: "92abb7c9-f6b4-46a4-a73f-1c56ddae5723");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                column: "ConcurrencyStamp",
                value: "c7137bfe-0147-471d-9c0b-3f7985533147");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                column: "ConcurrencyStamp",
                value: "98d31c06-d2ac-457a-9c24-aa29cc02de8d");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEC1/QErDJgWi6pws+F+6seSLfQYyO2ymEuSNikDy90mo8Y4z8J/U6+t9BkwasnS8cQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIIp4zKiESuMXfZQw4K3V11Y8PQXorcvPGKtQudEjDmYhVljSKtBl31K2ZP04JTCCQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIQieTQgKN/OAlfEDVPGRDrfFt67B8Xl2KGIgu3/uHE/BsbpzsNl7pgDzwzToCP7yg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOADyQVa8gN+ruLGXE4V69/yBCUA+wnjKZzYbf4mT0K/MdTUsCjTGn+bbPgjDA/p8w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEA8znHE0SMMF6lC1TucFviUbw9+xPPbwdfonXUy/OOcbV7MNnV7dm0yV6MIwTLx2xQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJ4ZUJbl4uJIFV9g0q40rxqBj7F7l3EPezcrfvzuqqRjPMKe4VCT/RdvBb3krG6Vvg==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(8368), new DateTime(2020, 12, 27, 17, 35, 0, 156, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(108), new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(161), new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(163), new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(167), new DateTime(2020, 12, 27, 17, 35, 0, 157, DateTimeKind.Local).AddTicks(168) });

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Email",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 98, DateTimeKind.Local).AddTicks(1537), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(3823), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(3877), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4608), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4650), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4942), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4945), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4948), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4951), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4954), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4957), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4959), new DateTime(2020, 12, 27, 17, 1, 35, 99, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(3147), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5155), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5195), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5200), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5203), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5206), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5209), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5212), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(4219), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(6018), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(6054), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                column: "ConcurrencyStamp",
                value: "41d33816-1275-4503-8c66-ae7332122ab1");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                column: "ConcurrencyStamp",
                value: "67813ce3-ee5a-415c-bb4e-c8c156017087");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                column: "ConcurrencyStamp",
                value: "ffba2660-f30c-4541-ab9b-09b5e37c70fc");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHeWRC2Sa/N4DwKER4LV+KD5K68jgPs1XHWpQyli1DOAwfkGFSpBY7OAKQ9KmGBAqg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEjptX+h0aq63G3UcXN6aI0sIxsEyhCIJlXe8x4fYiM2AUe0/jVGC0hwUEg3K8RkDQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKdXZCkHYgczPVy7AzmzhioZF+2drBQgLfL/hLpy9gmGiJjY8PHw5BURAJO0jniVbA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOVnTOZOFix+XnaFK5JsSqmyTzMMt+OdlbbMF1crrGU4ybps5bErecodcqv03/nySA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEK+Tu54WC98o5ieGpk1dQ2DqZIjbrpVyiGqeaZeVcrm2sOCV1sH1fWcL3ZgMFzisrg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDtjrAa3ca1byEm52mIRHxjI3NjwvgWU2v4FiLZe3481DIntXPpTgzvEM5LWPuQJ/g==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(9205), new DateTime(2020, 12, 27, 17, 1, 35, 100, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1096), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1165), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1169), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1171), new DateTime(2020, 12, 27, 17, 1, 35, 101, DateTimeKind.Local).AddTicks(1172) });
        }
    }
}
