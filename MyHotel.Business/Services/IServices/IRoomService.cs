using System.Collections.Generic;
using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;

namespace PlanBetter.Business.Services.IServices
{
    public interface IRoomService
    {
        public IEnumerable<Room> GetRooms();

        public Room GetRoom(int id);

        public int AddRoom(AddRoomModel room);

        public void UpdateRoom(Room room);

        public void DeleteRoom(int id);
    }
}
