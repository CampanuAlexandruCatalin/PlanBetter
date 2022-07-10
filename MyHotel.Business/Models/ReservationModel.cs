using System;
using System.Collections.Generic;

namespace PlanBetter.Business.Models
{
    public class ReservationModel
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime ReservationDate { get; set; }
        public ICollection<RoomModel> Rooms { get; set; }
        public GuestModel Guest { get; set; }
    }
}
