using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlanBetter.Persistance.Data.Migrations
{
    public partial class AddAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Student_id",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isApproval",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Room",
                table: "Exams",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "GroupName", "StudentId" },
                values: new object[,]
                {
                    { 1301, "c", 1 },
                    { 1302, "ti", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                columns: new[] { "DateOfJoin", "Dob" },
                values: new object[] { new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(3982), new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                columns: new[] { "DateOfJoin", "Dob" },
                values: new object[] { new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(3990), new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                columns: new[] { "DateOfJoin", "Dob" },
                values: new object[] { new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(3994), new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "DateOfJoin", "Dob", "Email", "FName", "JobTitle", "LName", "Mobile", "Password", "Status" },
                values: new object[,]
                {
                    { 91, new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(4023), new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(4021), "email1@facultate.profesor.com", "profesor", "laborant", "unu", "1234", "parola123", false },
                    { 92, new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(4029), new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(4027), "email2@facultate.profesor.com", "profesor", "doc. ing.", "doi", "07unudoi", "admin123", true },
                    { 93, new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(4033), new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(4032), "email3@facultate.profesor.com", "profesor", "profesor laborant", "trei", "0777666777", "parola", false }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName", "GroupId", "TeacherId" },
                values: new object[] { 100, "materie2", 1302, 92 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName", "GroupId", "TeacherId" },
                values: new object[] { 200, "materie1", 1301, 91 });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "ExamId", "CourseId", "Date", "Details", "GroupId", "Room", "StudentGroupId", "TeacherId", "TimeEnd", "TimeStart" },
                values: new object[,]
                {
                    { 551, 100, new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(4073), "examen grila", 1301, "teams meet", null, 91, new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(4075) },
                    { 552, 200, new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(4082), "examen scris", 1302, "google meet", null, 92, new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(4085), new DateTime(2022, 7, 25, 21, 33, 42, 555, DateTimeKind.Local).AddTicks(4084) }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CourseId", "QuestionText", "StudentId", "Student_id", "isApproval" },
                values: new object[,]
                {
                    { 991, 200, "salut?", null, 0, false },
                    { 992, 100, "?salut?", null, 0, false }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerText", "QuestionId", "TeacherId" },
                values: new object[] { 9991, "da", 991, 0 });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerText", "QuestionId", "TeacherId" },
                values: new object[] { 9992, "da?", 992, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9991);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9992);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DropColumn(
                name: "Student_id",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "isApproval",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Answers");

            migrationBuilder.AlterColumn<string>(
                name: "Room",
                table: "Exams",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                columns: new[] { "DateOfJoin", "Dob" },
                values: new object[] { new DateTime(2022, 7, 20, 19, 38, 39, 853, DateTimeKind.Local).AddTicks(6306), new DateTime(2022, 7, 20, 19, 38, 39, 853, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                columns: new[] { "DateOfJoin", "Dob" },
                values: new object[] { new DateTime(2022, 7, 20, 19, 38, 39, 853, DateTimeKind.Local).AddTicks(6319), new DateTime(2022, 7, 20, 19, 38, 39, 853, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                columns: new[] { "DateOfJoin", "Dob" },
                values: new object[] { new DateTime(2022, 7, 20, 19, 38, 39, 853, DateTimeKind.Local).AddTicks(6323), new DateTime(2022, 7, 20, 19, 38, 39, 853, DateTimeKind.Local).AddTicks(6321) });
        }
    }
}
