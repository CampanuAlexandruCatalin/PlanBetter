using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Domain.Entities
{
   public  class Question : BaseEntity
    {
        public int CourseId { get; set; }
        public string QuestionText { get; set; }

        public int Student_id { get; set; }
        public bool isApproval { get; set; }
        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}
