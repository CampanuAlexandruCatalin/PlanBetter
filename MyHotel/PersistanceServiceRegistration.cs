using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlanBetter.Domain.IRepositories;
using PlanBetter.Persistance.Data;
using PlanBetter.Persistance.Repositories;

namespace PlanBetter.Persistance
{
    public static class PersistanceServiceRegistration
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PlanBetterDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("PlanBetterConnectionString")));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IReservationRepository, ReservationRepository>();
            //services.AddScoped<IGuestRepository, GuestRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IStudentRepository, StudentRepository > ();
            services.AddScoped<IRoomRepository, RoomRepository>();

            return services;
        }
    }
}
