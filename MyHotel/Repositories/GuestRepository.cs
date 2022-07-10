using MyHotel.Data;
using MyHotel.Domain.Entities;
using MyHotel.Domain.IRepositories;
using MyHotel.Persistance.Data;

namespace MyHotel.Persistance.Repositories
{
    public class GuestRepository : BaseRepository<Guest>, IGuestRepository
    {
        public GuestRepository(MyHotelDbContext myHotelDbContext): base(myHotelDbContext)
        {

        }
    }
}
