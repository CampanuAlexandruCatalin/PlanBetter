using Microsoft.AspNetCore.Mvc;
using PlanBetter.Business.Models;
using PlanBetter.Business.Services.IServices;
using PlanBetter.Domain.Entities;

namespace PlanBetter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService _answerService;

        public AnswerController(IAnswerService answerService)
        {
            _answerService = answerService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_answerService.GetAns());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var answer = _answerService.GetAns(id);
            if (answer != null)
            {
                return Ok(answer);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Add([FromBody] AnswerModel model)
        {
            return CreatedAtAction(null, _answerService.AddAns(model));
        }
        [HttpPut]
        public IActionResult Update([FromBody] Answer answer)
        {
            _answerService.UpdateAns(answer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _answerService.DeleteAns(id);
            return NoContent();
        }
    }
}
