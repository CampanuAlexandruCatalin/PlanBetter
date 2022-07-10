using AutoMapper;
using MyHotel.Business.Models;
using MyHotel.Domain.Entities;

namespace MyHotel.Business.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Guest, GuestModel>().ReverseMap();
            CreateMap<Reservation, ReservationModel>().ReverseMap();
            CreateMap<Room, RoomModel>().ReverseMap();
            CreateMap<Room, AddRoomModel>().ReverseMap();
        }
       
    }
}
