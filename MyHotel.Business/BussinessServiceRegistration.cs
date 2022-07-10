using Microsoft.Extensions.DependencyInjection;
using MyHotel.Business.Services;
using System.Reflection;
using MyHotel.Business.Services.IServices;

namespace MyHotel.Business
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
