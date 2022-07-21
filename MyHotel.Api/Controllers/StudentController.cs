using Microsoft.AspNetCore.Mvc;
using PlanBetter.Business.Models;
using PlanBetter.Business.Services.IServices;
using PlanBetter.Domain.Entities;
namespace PlanBetter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
            private readonly IStudentService _studentService;

            public StudentController(IStudentService studentService)
            {
                _studentService = studentService;
            }

            [HttpGet]
            public IActionResult GetAll()
            {
               return Ok(_studentService.GetStudents());
            }

            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                var student = _studentService.GetStudent(id);
                if (student != null)
                {
                    return Ok(student);
                }

                return NotFound();

            }
        [HttpPost]
        public IActionResult Add([FromBody] AddStudentModel model)
        {
            return CreatedAtAction(null, _studentService.AddStudent(model));
        }
        [HttpPut]
        public IActionResult Update([FromBody] Student student)
        {
            _studentService.UpdateStudent(student);
            return NoContent();
        }


        [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                _studentService.DeleteStudent(id);
                return NoContent();
            }
        }
    }

