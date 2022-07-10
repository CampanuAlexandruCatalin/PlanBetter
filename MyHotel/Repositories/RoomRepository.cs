using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;
using PlanBetter.Persistance.Data;

namespace PlanBetter.Persistance.Repositories
{
    public class RoomRepository : BaseRepository<Room>, IRoomRepository
    {
        private static PlanBetterDbContext planBetterDbContext;

        public RoomRepository(PlanBetterDbContext myHotelDbContext) : base(planBetterDbContext)
        {

        }
    }
}
