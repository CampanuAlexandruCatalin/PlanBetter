using AutoMapper;
using PlanBetter.Business.Models;
using PlanBetter.Business.Services.IServices;
using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Business.Services
{
    internal class StudentGroupService: IStudentGroupService
    {
        private readonly IStudentGroupRepository _studentGroupRepository;
        private readonly IMapper _mapper;

        public StudentGroupService(IStudentGroupRepository studentGroupRepository, IMapper mapper)
        {
            _studentGroupRepository = studentGroupRepository;
            _mapper = mapper;
        }
        public int AddStudentGroup(AddStudentGroupModel studentGroup)
        {
            var newstudentGroup = _studentGroupRepository.Add(_mapper.Map<StudentGroup>(studentGroup));
            return newstudentGroup.Id;
        }

        public void DeleteStudentGroup(int id)
        {
            throw new NotImplementedException();
        }

        public StudentGroup GetStudentGroup(int id)
        {
            return _studentGroupRepository.GetById(id);
        }

        public IEnumerable<StudentGroup> GetStudentGroups()
        {
            return _studentGroupRepository.ListAll();
        }

        public void UpdateStudentGroup(StudentGroup studentGroup)
        {
            _studentGroupRepository.Update(studentGroup);
        }
    }
}
