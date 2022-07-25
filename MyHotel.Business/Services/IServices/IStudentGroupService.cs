using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Business.Services.IServices
{
    public interface IStudentGroupService
    {
        public IEnumerable<StudentGroup> GetStudentGroups();

        public StudentGroup GetStudentGroup(int id);

        public int AddStudentGroup(AddStudentGroupModel studentGroup);

        public void UpdateStudentGroup(StudentGroup studentGroup);

        public void DeleteStudentGroup(int id);
    }
}
