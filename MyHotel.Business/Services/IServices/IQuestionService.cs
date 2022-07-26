using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Business.Services.IServices
{
    public interface IQuestionService
    {
        public IEnumerable<Question> GetQuestions();

        public Question GetQuestion(int id);

        public int AddQuestion(QuestionModel question);

        public void UpdateQuestion(Question question);

        public void DeleteQuestion(int id);
    }
}
