using PlanBetter.Business.Models;

namespace PlanBetter.Business.Services.IServices
{
    public interface IReservationService
    {
        int AddReservation(ReservationModel reservationModel);
        bool CheckReservation(ReservationModel reservationModel);
    }
}
