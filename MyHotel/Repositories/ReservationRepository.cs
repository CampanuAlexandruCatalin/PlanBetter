using System;
using System.Collections.Generic;
using PlanBetter.Domain.IRepositories;
using System.Linq;
using PlanBetter.Domain.Entities;
using PlanBetter.Persistance.Data;

namespace PlanBetter.Persistance.Repositories
{
    public class ReservationRepository : BaseRepository<Reservation>, IReservationRepository
    {
        private static PlanBetterDbContext planBetterDbContext;

        public ReservationRepository(PlanBetterDbContext myHotelDbContext): base(planBetterDbContext)
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
