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
    internal class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        public int AddStudent(StudentModel student)
        {
            var newstudent = _studentRepository.Add(_mapper.Map<Student>(student));
            return newstudent.Id;
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            return _studentRepository.GetById(id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _studentRepository.ListAll();
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.Update(student);
        }
    }
}
