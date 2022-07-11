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
    public sealed class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _qnRepository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository qnRepository, IMapper mapper)
        {
            _qnRepository = qnRepository;
            _mapper = mapper;
        }

        public IEnumerable<Question> GetQuestions()
        {
            return _qnRepository.ListAll();
        }

        public Question GetQuestion(int id)
        {
            return _qnRepository.GetById(id);
        }

        public int AddQuestion(QuestionModel question)
        {
            var newqn = _qnRepository.Add(_mapper.Map<Question>(question));
            return newqn.Id;
        }

        public void UpdateQuestion(Question question)
        {
            _qnRepository.Update(question);
        }

        public void DeleteQuestion(int id)
        {
            var question = _qnRepository.GetById(id);
            if (question != null)
            {
                _qnRepository.Delete(question);
            }
        }
    }
}
