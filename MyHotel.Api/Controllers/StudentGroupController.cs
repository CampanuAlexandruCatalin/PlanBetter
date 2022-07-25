using Microsoft.AspNetCore.Mvc;
using PlanBetter.Business.Models;
using PlanBetter.Business.Services.IServices;
using PlanBetter.Domain.Entities;
namespace PlanBetter.Api.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
    public class StudentGroupController : ControllerBase
    {
        private readonly IStudentGroupService _studentGroupService;

        public StudentGroupController(IStudentGroupService studentGroupService)
        {
            _studentGroupService = studentGroupService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_studentGroupService.GetStudentGroups());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var teacher = _studentGroupService.GetStudentGroup(id);
            if (teacher != null)
            {
                return Ok(teacher);
            }

            return NotFound();

        }
        [HttpPost]
        public IActionResult Add([FromBody] AddStudentGroupModel model)
        {
            return CreatedAtAction(null, _studentGroupService.AddStudentGroup(model));
        }
        [HttpPut]
        public IActionResult Update([FromBody] StudentGroup studentGroup)
        {
            _studentGroupService.UpdateStudentGroup(studentGroup);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _studentGroupService.DeleteStudentGroup(id);
            return NoContent();
        }
    }
    
}
