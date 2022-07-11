using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PlanBetter.Domain.Entities
{
    public class Student : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime Dob { get; set; }
        public string Mobile { get; set; }
        public DateTime DateOfJoin { get; set; }
        public bool Status { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}