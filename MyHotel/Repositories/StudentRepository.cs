using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;
using PlanBetter.Persistance.Data;

namespace PlanBetter.Persistance.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(PlanBetterDbContext planBetterDbContext) : base(planBetterDbContext)
        {

        }
    }
}
