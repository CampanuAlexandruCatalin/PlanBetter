using Microsoft.Extensions.DependencyInjection;
using PlanBetter.Business.Services;
using System.Reflection;
using PlanBetter.Business.Services.IServices;

namespace PlanBetter.Business
{
    public static class BussinessServiceRegistration 
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
          
            
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IAnswerService, AnswerService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ITeacherService, TeacherService>();
            return services;
        }
    }
}
