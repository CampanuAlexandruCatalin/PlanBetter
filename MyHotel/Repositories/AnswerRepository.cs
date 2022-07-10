using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;
using PlanBetter.Persistance.Data;

namespace PlanBetter.Persistance.Repositories
{
    public class AnswerRepository : BaseRepository<Answer>, IAnswerRepository
    {
        public AnswerRepository(PlanBetterDbContext planBetterDbContext) : base(planBetterDbContext)
        {

        }
    }
}
