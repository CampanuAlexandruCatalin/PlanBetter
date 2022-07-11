using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Business.Services.IServices
{
 public   interface ITeacherService
    {
        public IEnumerable<Teacher> GetTeachers();

        public Teacher GetTeacher(int id);
    }
}
