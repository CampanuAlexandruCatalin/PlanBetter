using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;

namespace PlanBetter.Business.Models
{
    public class TeacherModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime Dob { get; set; }
        public string Mobile { get; set; }
        public DateTime DateOfJoin { get; set; }
        public bool Status { get; set; }
        public string JobTitle { get; set; }
        public ICollection<CourseModel> Courses { get; set; }
    }
}
