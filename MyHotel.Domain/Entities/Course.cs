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
        public int Teacher_Id { get; set; }
        public int Group_Id { get; set; }
    }
}
