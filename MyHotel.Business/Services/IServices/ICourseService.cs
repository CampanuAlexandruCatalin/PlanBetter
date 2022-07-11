using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Business.Services.IServices
{
    internal interface ICourseService
    {
        public IEnumerable<Course> GetCourses();

        public Course GetCourse(int id);

        public int AddCourse(CourseModel course);

        public void UpdateCourse(Course course);

        public void DeleteCourse(int id);
    }
}
