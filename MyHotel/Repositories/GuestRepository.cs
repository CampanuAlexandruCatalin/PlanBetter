using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;
using PlanBetter.Persistance.Data;

namespace PlanBetter.Persistance.Repositories
{
    public class GuestRepository : BaseRepository<Teacher>, IGuestRepository
    {
        public GuestRepository(PlanBetterDbContext planBetterDbContext): base(planBetterDbContext)
        {

        }
    }
}
