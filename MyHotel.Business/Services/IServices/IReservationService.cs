using MyHotel.Business.Models;

namespace MyHotel.Business.Services.IServices
{
    public interface IReservationService
    {
        int AddReservation(ReservationModel reservationModel);
        bool CheckReservation(ReservationModel reservationModel);
    }
}
