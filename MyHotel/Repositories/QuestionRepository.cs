using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;
using PlanBetter.Persistance.Data;

namespace PlanBetter.Persistance.Repositories
{
    public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(PlanBetterDbContext planBetterDbContext) : base(planBetterDbContext)
        {

        }
    }
}
