using System;
using System.Collections.Generic;
using PlanBetter.Domain.Entities;

namespace PlanBetter.Domain.IRepositories
{
    public interface IReservationRepository : IBaseRepository<Reservation>
    {
        IEnumerable<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut);
    }
}