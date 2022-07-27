using Microsoft.AspNetCore.Mvc;
using PlanBetter.Business.Models;
using PlanBetter.Business.Services.IServices;
using PlanBetter.Domain.Entities;
namespace PlanBetter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController:ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        } 
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_questionService.GetQuestions());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var question = _questionService.GetQuestion(id);
            if(question!=null)
            {
                return Ok(question);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Add([FromBody] QuestionModel model)
        {
            return CreatedAtAction(null, _questionService.AddQuestion(model));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Question model)
        {
            _questionService.UpdateQuestion(model);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _questionService.DeleteQuestion(id);
            return NoContent();
        }
    }
}
