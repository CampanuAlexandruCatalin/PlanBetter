using System.Collections.Generic;
using AutoMapper;
using MyHotel.Business.Models;
using MyHotel.Business.Services.IServices;
using MyHotel.Domain.Entities;
using MyHotel.Domain.IRepositories;

namespace MyHotel.Business.Services
{
    public sealed class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;

        public RoomService(IRoomRepository roomRepository, IMapper mapper)
        {
            _roomRepository = roomRepository;
            _mapper = mapper;
        }

        public IEnumerable<Room> GetRooms()
        {
            return _roomRepository.ListAll();
        }

        public Room GetRoom(int id)
        {
            return _roomRepository.GetById(id);
        }

        public int AddRoom(AddRoomModel room)
        {
            var newRoom = _roomRepository.Add(_mapper.Map<Room>(room));
            return newRoom.Id;
        }

        public void UpdateRoom(Room room)
        {
            _roomRepository.Update(room);
        }

        public void DeleteRoom(int id)
        {
            var room = _roomRepository.GetById(id);
            if (room != null)
            {
                _roomRepository.Delete(room);
            }
        }
    }
}
