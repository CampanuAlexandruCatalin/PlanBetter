using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Business.Services.IServices
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetStudents();

        public Student GetStudent(int id);

        public int AddStudent(StudentModel student);

        public void UpdateStudent(Student student);

        public void DeleteStudent(int id);
    }
}
