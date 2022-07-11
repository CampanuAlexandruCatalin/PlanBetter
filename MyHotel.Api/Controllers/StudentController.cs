using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using PlanBetter.Business.Services.IServices;

namespace PlanBetter.Api.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
            private readonly IStudentService _studentService;

            public StudentController(IStudentService studentService)
            {
                _studentService = studentService;
            }

            //[HttpGet]
            //public IActionResult GetAll()
            //{
            //    return Ok(_studentService.GetStudents());
            //}

            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                var room = _studentService.GetStudent(id);
                if (room != null)
                {
                    return Ok(room);
                }

                return NotFound();

            }


            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                _studentService.DeleteStudent(id);
                return NoContent();
            }
        }
    }

