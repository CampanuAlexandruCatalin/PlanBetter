using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlanBetter.Api.Controllers;
using PlanBetter.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalanBetter.IntegrationTests
{
   public class BaseIntegrationTests
    {
        private WebApplicationFactory<StudentController> _application;
        protected HttpClient HttpClient { get; private set; }
        [TestInitialize]
        public async Task TestInitialize()
        {
            _application = new WebApplicationFactory<StudentController>()
                .WithWebHostBuilder(_ => { });

            HttpClient = _application.CreateClient();

            await CleanupDatabase();
        }
        [TestCleanup]
        public async Task TestCleanup()
        {
            await CleanupDatabase();
        }

        private async Task CleanupDatabase()
        {
            using var scope = _application.Services.CreateScope();
            var databaseContext = scope.ServiceProvider.GetRequiredService<PlanBetterDbContext>();
            databaseContext.Database.Migrate();
            databaseContext.Students.RemoveRange(databaseContext.Students.ToList());
            databaseContext.Teachers.RemoveRange(databaseContext.Teachers.ToList());
            databaseContext.StudentGroups.RemoveRange(databaseContext.StudentGroups.ToList());
            databaseContext.Questions.RemoveRange(databaseContext.Questions.ToList());
            databaseContext.Answers.RemoveRange(databaseContext.Answers.ToList());
            databaseContext.Courses.RemoveRange(databaseContext.Courses.ToList());
            await databaseContext.SaveChangesAsync();
        }
    }
}
