using Microsoft.AspNetCore.Mvc;
using PlanBetter.Business.Models;
using PlanBetter.Business.Services.IServices;
using PlanBetter.Domain.Entities;

namespace PlanBetter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;

        public ExamController(IExamService examService)
        {
            _examService = examService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_examService.GetExams());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var exam = _examService.GetExam(id);
            if (exam != null)
            {
                return Ok(exam);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Add([FromBody] AddExamModel model)
        {
            return CreatedAtAction(null, _examService.AddExam(model));
        }
        [HttpPut]
        public IActionResult Update([FromBody] Exam exam)
        {
            _examService.UpdateExam(exam);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _examService.DeleteExam(id);
            return NoContent();
        }

    }
}
