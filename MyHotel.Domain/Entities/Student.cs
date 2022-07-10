using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PlanBetter.Domain.Entities
{
    public class Student : BaseEntity
    {
        public string email { get; set; }
        public string password { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public DateTime dob { get; set; }
        public string mobile { get; set; }
        public DateTime date_of_join { get; set; }
        public bool status { get; set; }
    }
}