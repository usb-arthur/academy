using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMY.WebApi.Migrations
{
    public partial class AddFieldForCourseAndCourseDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "CourseDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsReview",
                table: "CourseDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Sale",
                table: "Course",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "SaleDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(2358), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3568), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3603), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3606), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3609), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3612), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3614), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3617), new DateTime(2021, 1, 6, 23, 10, 30, 4, DateTimeKind.Local).AddTicks(3618) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_CourseId",
                table: "Feedback",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Course_CourseId",
                table: "Feedback",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Course_CourseId",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropIndex(
                name: "IX_Feedback_CourseId",
                table: "Feedback");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "CourseDetail");

            migrationBuilder.DropColumn(
                name: "IsReview",
                table: "CourseDetail");

            migrationBuilder.DropColumn(
                name: "Sale",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "SaleDate",
                table: "Course");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 842, DateTimeKind.Local).AddTicks(2709), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(4980), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5021), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5326), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5345), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5348), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5351), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5354), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5357), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5359), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5362), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5366), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(7981), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9048), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9083), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9087), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9090), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9097), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9100), new DateTime(2021, 1, 6, 22, 5, 41, 843, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(4263), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(5273), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(5308), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09e89e3b-00dd-4580-a403-63fc3f91ab50"),
                column: "ConcurrencyStamp",
                value: "bb86d9d2-3c97-4d2d-b1c8-d9d8ddb692b1");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85baa706-7544-477e-ba32-004d478a7200"),
                column: "ConcurrencyStamp",
                value: "5b162361-961f-40a3-bb86-5d86e5b58051");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ad0e4e6a-fee6-4ccf-91eb-5f357e04e467"),
                column: "ConcurrencyStamp",
                value: "185d52ef-8f4f-4948-bea2-2c4c4a9c0cd0");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEC2t6aKpk/axSFDN2unC1lXYrUDldfzY+B3276hlGOlViU8tNZ4S4WeqEUBgAy9SWQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92f252eb-f35c-4d29-864a-5fbdcb82bd2e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGSOSZLmB3mdwcvSS59vHshq3izWcYKP3AC9pAnsDSlnLMpuhZyDZjo+NNLtdoLmbg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("babb8adf-190d-48ca-a9fe-a3b7c06fb58d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMRZhXkNzH+bUhYekGnTxIkPomlXCzzIn4WCNoQs//LFGDnNlYft1Z61ggRb0SpplA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6f46571-9f16-4c94-9f78-fb5c56b7caa9"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBClKfdP3DSq5SfpiwZr595uC7Oy7JzAmSEjdGxbsF1qigvhNhTHcw7spoZqTDKp8Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0181bf8-fc45-4122-97b0-1c4990a4983d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIUwf5t1jFUWUTccnjNgL+GIH0TxYS++Zs0Tcybbgsm+FcYWJz/4DVeDzVosb+KCiw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eafef07d-95fb-473d-b38e-57ea4a29968d"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFdWLgV0D3FigBz7B/T6kCK05lCEwDSEwUa+NyD9vHEW/oT3Ixh9DqauEMTzCzDXFg==");

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(1041), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2359), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2459), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2462), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "WatchList",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5L, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2465), new DateTime(2021, 1, 6, 22, 5, 41, 844, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
