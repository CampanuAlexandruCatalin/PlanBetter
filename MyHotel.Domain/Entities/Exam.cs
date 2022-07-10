using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Domain.Entities
{
     public class Exam : BaseEntity
    {
        public int course_id { get; set; }
        public int teacher_id { get; set; }
        public int group_id { get; set; }
        public DateTime date { get; set; }
        public DateTime time_start { get; set; }
        public DateTime time_end { get; set; }
        public string room_no { get; set; }
        public string details { get; set; }
    }
}
