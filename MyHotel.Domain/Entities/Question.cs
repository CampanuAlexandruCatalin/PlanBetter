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
        public int course_id { get; set; }
        public string question_text { get; set; }
    }
}
