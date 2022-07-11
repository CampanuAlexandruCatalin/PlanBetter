using System.Collections.Generic;

namespace PlanBetter.Business.Models
{
    public class CourseModel
    {
        public string CourseName { get; set; }
        public int TeacherId { get; set; }
        public int GroupId { get; set; }
        public ICollection<QuestionModel> Questions { get; set; }
        public ICollection<ExamModel> Exams { get; set; }

    }
}
