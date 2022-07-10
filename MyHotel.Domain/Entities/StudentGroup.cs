using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Domain.Entities
{
    public class StudentGroup:BaseEntity
    {
        public int StudentId { get; set; }
        public string GroupName { get; set; }
    }
}
