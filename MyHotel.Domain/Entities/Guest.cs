using System.Collections.Generic;

namespace MyHotel.Domain.Entities
{
    public class Guest : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string SSN { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
