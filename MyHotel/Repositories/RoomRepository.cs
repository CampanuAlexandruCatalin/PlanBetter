using MyHotel.Data;
using MyHotel.Domain.Entities;
using MyHotel.Domain.IRepositories;
using MyHotel.Persistance.Data;

namespace MyHotel.Persistance.Repositories
{
    public class RoomRepository : BaseRepository<Room>, IRoomRepository
    {
        public RoomRepository(MyHotelDbContext myHotelDbContext) : base(myHotelDbContext)
        {

        }
    }
}
