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
    public sealed class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository _ansRepository;
        private readonly IMapper _mapper;

        public AnswerService(IAnswerRepository ansRepository, IMapper mapper)
        {
            _ansRepository = ansRepository;
            _mapper = mapper;
        }

        public IEnumerable<Answer> GetAns()
        {
            return _ansRepository.ListAll();
        }

        public Answer GetAns(int id)
        {
            return _ansRepository.GetById(id);
        }

        public int AddAns(AnswerModel ans)
        {
            var newans = _ansRepository.Add(_mapper.Map<Answer>(ans));
            return newans.Id;
        }

        public void UpdateAns(Answer ans)
        {
            _ansRepository.Update(ans);
        }

        public void DeleteAns(int id)
        {
            var ans = _ansRepository.GetById(id);
            if (ans != null)
            {
                _ansRepository.Delete(ans);
            }
        }
    }
}
