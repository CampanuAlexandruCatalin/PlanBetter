using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;
using PlanBetter.Persistance.Data;

namespace PlanBetter.Persistance.Repositories
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(PlanBetterDbContext planBetterDbContext) : base(planBetterDbContext)
        {

        }
    }
}
