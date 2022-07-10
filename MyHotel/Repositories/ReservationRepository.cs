using System;
using System.Collections.Generic;
using MyHotel.Domain.IRepositories;
using System.Linq;
using MyHotel.Domain.Entities;
using MyHotel.Persistance.Data;

namespace MyHotel.Persistance.Repositories
{
    public class ReservationRepository : BaseRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(MyHotelDbContext myHotelDbContext): base(myHotelDbContext)
        {

        }

        public IEnumerable<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut)
        {
            var roomsReserved = _dbContext.Reservations.Where(res => res.CheckIn <= checkIn && res.CheckOut > checkIn)
                .Where(res => res.CheckIn >= checkIn && res.CheckIn < checkOut)
                .SelectMany(res => res.Rooms)
                .ToList();
            return _dbContext.Rooms
                .ToList()
                .Except(roomsReserved);
        }
    }
}
