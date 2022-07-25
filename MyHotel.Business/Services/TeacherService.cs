using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PlanBetter.Business.Services.IServices;
using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;

namespace PlanBetter.Business.Services
{
    public sealed class TeacherService :ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;
        public TeacherService(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }
        public IEnumerable<Teacher> GetTeachers()
        {
            return _teacherRepository.ListAll();
        }
        public Teacher GetTeacher(int id)
        {
            return _teacherRepository.GetById(id);
        }
        public void DeleteTeacher(int id)
        {
            throw new NotImplementedException();
        }


    }
}
