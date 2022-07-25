using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Business.Services.IServices
{
 public interface ITeacherService
    {
        public IEnumerable<Teacher> GetTeachers();

        public Teacher GetTeacher(int id);
        public int AddTeacher(TeacherModel teacher);

        public void UpdateTeacher(Teacher teacher);

        public void DeleteTeacher(int id);
    }
}
