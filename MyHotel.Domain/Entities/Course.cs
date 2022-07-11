using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Domain.Entities
{
   public class Course :BaseEntity
    {
        public string CourseName { get; set; }
        public int TeacherId { get; set; }
        public int GroupId { get; set; }
        public ICollection<Question> Questions { get; set; } = new List<Question>();
        public ICollection<Exam> Exams { get; set; } = new List<Exam>();

    }
}
