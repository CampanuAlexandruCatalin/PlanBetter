using System.Collections.Generic;

namespace PlanBetter.Business.Models
{
    public class QuestionModel
    {
        public int CourseId { get; set; }
        public string QuestionText { get; set; }
        public ICollection<AnswerModel> Answers { get; set; }
    }
}
