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
                values: new object[] { new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(721), new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                columns: new[] { "DateOfJoin", "Dob" },
                values: new object[] { new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(730), new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                columns: new[] { "DateOfJoin", "Dob" },
                values: new object[] { new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(734), new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "DateOfJoin", "Dob", "Email", "FName", "JobTitle", "LName", "Mobile", "Password", "Status" },
                values: new object[,]
                {
                    { 91, new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(765), new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(762), "email1@facultate.profesor.com", "profesor", "laborant", "unu", "1234", "parola123", false },
                    { 92, new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(771), new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(769), "email2@facultate.profesor.com", "profesor", "doc. ing.", "doi", "07unudoi", "admin123", true },
                    { 93, new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(776), new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(774), "email3@facultate.profesor.com", "profesor", "profesor laborant", "trei", "0777666777", "parola", false }
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
                    { 551, 100, new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(815), "examen grila", 1301, "teams meet", null, 91, new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(819), new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(817) },
                    { 552, 200, new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(823), "examen scris", 1302, "google meet", null, 92, new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(826), new DateTime(2022, 7, 27, 11, 34, 21, 708, DateTimeKind.Local).AddTicks(825) }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CourseId", "QuestionText", "StudentId", "Student_id", "isApproval" },
                values: new object[,]
                {
                    { 991, 200, "salut?", null, 1, false },
                    { 992, 100, "?salut?", null, 2, false }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerText", "QuestionId", "TeacherId" },
                values: new object[] { 9991, "da", 991, 991 });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerText", "QuestionId", "TeacherId" },
                values: new object[] { 9992, "da?", 992, 992 });
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
