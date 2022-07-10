using System;
using System.Collections.Generic;
using MyHotel.Domain.Entities;

namespace MyHotel.Domain.IRepositories
{
    public interface IReservationRepository : IBaseRepository<Reservation>
    {
        IEnumerable<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut);
    }
}
