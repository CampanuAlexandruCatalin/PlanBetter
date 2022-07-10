using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Domain.Entities
{
   public class Answer :BaseEntity
    {
        public int question_id { get; set; }
        public string answer_text { get; set; }
    }
}
