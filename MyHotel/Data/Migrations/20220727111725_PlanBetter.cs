using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlanBetter.Persistance.Data.Migrations
{
    public partial class PlanBetter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Pass = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Fname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DateOfJoin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfJoin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Room = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Details = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    StudentGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.ExamId);
                    table.ForeignKey(
                        name: "FK_Exams_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exams_StudentGroups_StudentGroupId",
                        column: x => x.StudentGroupId,
                        principalTable: "StudentGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    isApproval = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "GroupName", "StudentId" },
                values: new object[,]
                {
                    { 1301, "c", 1 },
                    { 1302, "ti", 2 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfJoin", "Dob", "Email", "Fname", "Lname", "Mobile", "Pass", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6240), new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6201), "email1@facultate.student.com", "student", "unu", "1234", "parola123", false },
                    { 2, new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6250), new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6247), "email2@facultate.student.com", "student", "doi", "07unudoi", "admin123", true },
                    { 3, new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6254), new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6252), "email3@facultate.student.com", "student", "trei", "0777666777", "parola", false }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "DateOfJoin", "Dob", "Email", "FName", "JobTitle", "LName", "Mobile", "Password", "Status" },
                values: new object[,]
                {
                    { 91, new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6287), new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6285), "email1@facultate.profesor.com", "profesor", "laborant", "unu", "1234", "parola123", false },
                    { 92, new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6294), new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6292), "email2@facultate.profesor.com", "profesor", "doc. ing.", "doi", "07unudoi", "admin123", true },
                    { 93, new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6299), new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6297), "email3@facultate.profesor.com", "profesor", "profesor laborant", "trei", "0777666777", "parola", false }
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
                    { 551, 100, new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6341), "examen grila", 1301, "teams meet", null, 91, new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6345), new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6343) },
                    { 552, 200, new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6351), "examen scris", 1302, "google meet", null, 92, new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6355), new DateTime(2022, 7, 27, 14, 17, 25, 157, DateTimeKind.Local).AddTicks(6353) }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CourseId", "QuestionText", "StudentId", "isApproval" },
                values: new object[,]
                {
                    { 991, 200, "salut?", 1, false },
                    { 992, 100, "?salut?", 2, false }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerText", "QuestionId", "TeacherId" },
                values: new object[] { 9991, "da", 991, 991 });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerText", "QuestionId", "TeacherId" },
                values: new object[] { 9992, "da?", 992, 992 });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CourseId",
                table: "Exams",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_StudentGroupId",
                table: "Exams",
                column: "StudentGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CourseId",
                table: "Questions",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_StudentId",
                table: "Questions",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "StudentGroups");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
