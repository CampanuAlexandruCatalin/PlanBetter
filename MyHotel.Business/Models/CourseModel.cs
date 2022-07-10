using System.Collections.Generic;

namespace PlanBetter.Business.Models
{
    public class CourseModel
    {
        public string CourseName { get; set; }
        public int Teacher_id { get; set; }
        public int Group_id { get; set; }
        public ICollection<QuestionModel> Questions { get; set; }
        public ICollection<ExamModel> Exams { get; set; }

    }
}
