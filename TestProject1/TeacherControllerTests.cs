using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using PlanBetter.Api;
using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PalanBetter.IntegrationTests
{
    [TestClass]
    public class TeacherControllerTests
    {
        [TestMethod]
        public async Task When_AddTeacher_ShouldInserTeacher()
        {
            //Arrange
            var application = new WebApplicationFactory<Startup>()
        .WithWebHostBuilder(builder =>
        {
            // ... Configure test services
        });
            var client = application.CreateClient();

            var model = new TeacherModel()
            {
                Email = "profesor1@academic.com",
                Password = "password",
                FName = "fname",
                LName = "lname",
                Dob = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8239),
                Mobile = "0712",
                Status = true,
                DateOfJoin = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8239),
                JobTitle = "inginer",
            };
            //Act
            var result = await client.PostAsJsonAsync("api/teacher", model);


            //Assert
            result.EnsureSuccessStatusCode();


            var teacherIdFromResult = await result.Content.ReadAsStringAsync();
            teacherIdFromResult.Should().NotBeNullOrEmpty();


            var resultOfGetTeacherById = await client.GetAsync($"api/teacher/{teacherIdFromResult}");
            resultOfGetTeacherById.EnsureSuccessStatusCode();


            var teacherFromResult = await resultOfGetTeacherById.Content.ReadFromJsonAsync<Teacher>();
            teacherFromResult.Should().NotBeNull();
            teacherFromResult.Id.ToString().Should().Be(teacherIdFromResult);
        }

        [TestMethod]
        public async Task When_UpdateDatabase_ShouldChangeTeacherData()
        {
            //Arrange
            var application = new WebApplicationFactory<Startup>()
        .WithWebHostBuilder(builder =>
        {
            // ... Configure test services
        });

            var client = application.CreateClient();
            var addTeacherModel = new AddTeacherModel()
            {
                Email = "profesor1@academic.com",
                Password = "password",
                FName = "fname",
                LName = "lname",
                Dob = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8239),
                Mobile = "0712",
                Status = true,
                DateOfJoin = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8239),
                JobTitle = "inginer",
            };
            var result = await client.PostAsJsonAsync("api/teacher", addTeacherModel);
            result.EnsureSuccessStatusCode();
            var teacherIdFromResult = await result.Content.ReadAsStringAsync();

            var expectedChangeTeacherStatus = false;
            var teacher = new Teacher()
            {
                Id = Convert.ToInt32(teacherIdFromResult),
                Email = "profesor1@academic.com",
                Password = "password",
                FName = "fname",
                LName = "lname",
                Dob = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8239),
                Mobile = "0712",
                DateOfJoin = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8239),
                JobTitle = "inginer",
                Status = expectedChangeTeacherStatus
            };
            //Act
            var resultForUpdateTeacher = await client.PutAsJsonAsync("api/teacher", teacher);


            //Assert
            resultForUpdateTeacher.EnsureSuccessStatusCode();

            var resultOfGetTeacherById = await client.GetAsync($"api/teacher/{teacherIdFromResult}");
            resultOfGetTeacherById.EnsureSuccessStatusCode();
            var teacherFromResult = await resultOfGetTeacherById.Content.ReadFromJsonAsync<Teacher>();

            teacherFromResult.Should().NotBeNull();
            teacherFromResult.Id.ToString().Should().Be(teacherIdFromResult);

            teacherFromResult.Status.Should().Be(expectedChangeTeacherStatus);
        }
    }
}
