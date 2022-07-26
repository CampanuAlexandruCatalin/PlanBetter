using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using PlanBetter.Api;
using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;
using System.Net.Http.Json;

namespace PlanBetter.IntegrationTests
{
    [TestClass]
    public class StudentControllerTests
    {
        [TestMethod]
        public async Task When_AddStudent_ShouldInsertStudent()
        {
            //Arrange
            var application = new WebApplicationFactory<Startup>()
        .WithWebHostBuilder(builder =>
        {
            // ... Configure test services
        });
            var client = application.CreateClient();

            var model = new AddStudentModel()
            {
                Email = "eueu",
                Password = "eueu",
                FName = "Prenume",
                LName = "Nume",
                DateOfJoin = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8251),
                Dob = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8239),
                Mobile = "07548920",
                Status = true
            };

            //Act
            var result = await client.PostAsJsonAsync("api/student", model);


            //Assert
            result.EnsureSuccessStatusCode();


            var studentIdFromResult = await result.Content.ReadAsStringAsync();
            studentIdFromResult.Should().NotBeNullOrEmpty();


            var resultOfGetStudentById = await client.GetAsync($"api/student/{studentIdFromResult}");
            resultOfGetStudentById.EnsureSuccessStatusCode();


            var studentFromResult = await resultOfGetStudentById.Content.ReadFromJsonAsync<Student>();
            studentFromResult.Should().NotBeNull();
            studentFromResult.Id.ToString().Should().Be(studentIdFromResult);
        }

        [TestMethod]
        public async Task When_UpdateDatabase_ShouldChangeStudentData()
        {
            //Arrange
            var application = new WebApplicationFactory<Startup>()
        .WithWebHostBuilder(builder =>
        {
                // ... Configure test services
        });

            var client = application.CreateClient();
            var addStudentModel = new AddStudentModel()
            {
                Email = "eueu",
                Password = "eueu",
                FName = "Prenume",
                LName = "Nume",
                DateOfJoin = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8251),
                Dob = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8239),
                Mobile = "07548920",
                Status = true
            };
            var result = await client.PostAsJsonAsync("api/student", addStudentModel);
            result.EnsureSuccessStatusCode();
            var studentIdFromResult = await result.Content.ReadAsStringAsync();

            var expectedChangeStudentStatus = false;
            var student = new Student()
            {
                Id = Convert.ToInt32(studentIdFromResult),
                Email = "eueu",
                Password = "eueu",
                FName = "Prenume",
                LName = "Nume",
                DateOfJoin = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8251),
                Dob = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8239),
                Mobile = "07548920",
                Status = expectedChangeStudentStatus
            };
            //Act
            var resultForUpdateStudent = await client.PutAsJsonAsync("api/student", student);


            //Assert
            resultForUpdateStudent.EnsureSuccessStatusCode();

            var resultOfGetStudentById = await client.GetAsync($"api/student/{studentIdFromResult}");
            resultOfGetStudentById.EnsureSuccessStatusCode();
            var studentFromResult = await resultOfGetStudentById.Content.ReadFromJsonAsync<Student>();

            studentFromResult.Should().NotBeNull();
            studentFromResult.Id.ToString().Should().Be(studentIdFromResult);

            studentFromResult.Status.Should().Be(expectedChangeStudentStatus);
        }
      
    }
}