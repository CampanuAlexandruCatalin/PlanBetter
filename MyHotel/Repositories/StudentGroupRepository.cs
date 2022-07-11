using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;
using PlanBetter.Persistance.Data;

namespace PlanBetter.Persistance.Repositories
{
   
    public class StudentGroupRepository : BaseRepository<StudentGroup>, IStudentGroupRepository
    {
        public StudentGroupRepository(PlanBetterDbContext planBetterDbContext) : base(planBetterDbContext)
        {

        }
    }
}
