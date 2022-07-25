using Microsoft.AspNetCore.Mvc;
using PlanBetter.Business.Models;
using PlanBetter.Business.Services.IServices;
using PlanBetter.Domain.Entities; 
namespace PlanBetter.Api.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
    public class TeacherController : ControllerBase
    {
            private readonly ITeacherService _teacherService;

            public TeacherController(ITeacherService teacherService)
            {
                _teacherService = teacherService;
            }

            [HttpGet]
            public IActionResult GetAll()
            {
                return Ok(_teacherService.GetTeachers());
            }

            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                var teacher = _teacherService.GetTeacher(id);
                if (teacher != null)
                {
                    return Ok(teacher);
                }

                return NotFound();

            }
            [HttpPost]
            public IActionResult Add([FromBody] AddTeacherModel model)
            {
                return CreatedAtAction(null, _teacherService.AddTeacher(model));
            }
            [HttpPut]
            public IActionResult Update([FromBody] Teacher teacher)
            {
                _teacherService.UpdateTeacher(teacher);
                return NoContent();
            }


            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                _teacherService.DeleteTeacher(id);
                return NoContent();
            }
        }
    
}
