using System.Collections.Generic;

namespace PlanBetter.Business.Models
{
    public class QuestionModel
    {
        public int CourseId { get; set; }
        public string QuestionText { get; set; }
        public int StudentId { get; set; }
        public bool isApproval { get; set; }
        public ICollection<AddAnswerModel> Answers { get; set; }
    }
}
