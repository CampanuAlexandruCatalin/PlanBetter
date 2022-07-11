using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Business.Services.IServices
{
    public interface IExamService
    {
        public IEnumerable<Exam> GetExams();

        public Exam GetExam(int id);

        public int AddExam(AddExamModel exam);

        public void UpdateExam(Exam exam);

        public void DeleteExam(int id);
    }
}
