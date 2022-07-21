using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Business.Models
{
    public sealed class AddStudentModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime Dob { get; set; }
        public string Mobile { get; set; }
        public DateTime DateOfJoin { get; set; }
        public bool Status { get; set; }
    }
}
