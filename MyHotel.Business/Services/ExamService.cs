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
    public sealed class ExamService : IExamService
    {
        private readonly IExamRepository _examRepository;
        private readonly IMapper _mapper;

        public ExamService(IExamRepository examRepository, IMapper mapper)
        {
            _examRepository = examRepository;
            _mapper = mapper;
        }

        public IEnumerable<Exam> GetExams()
        {
            return _examRepository.ListAll();
        }

        public Exam GetExam(int id)
        {
            return _examRepository.GetById(id);
        }

        public int AddExam(AddExamModel exam)
        {
            var newExam = _examRepository.Add(_mapper.Map<Exam>(exam));
            return newExam.Id;
        }

        public void UpdateExam(Exam exam)
        {
            _examRepository.Update(exam);
        }

        public void DeleteExam(int id)
        {
            var exam = _examRepository.GetById(id);
            if (exam != null)
            {
                _examRepository.Delete(exam);
            }
        }
    }
}
