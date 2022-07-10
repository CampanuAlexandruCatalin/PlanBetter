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
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
