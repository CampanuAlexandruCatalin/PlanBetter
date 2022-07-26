using Microsoft.AspNetCore.Mvc;
using PlanBetter.Business.Models;
using PlanBetter.Business.Services.IServices;
using PlanBetter.Domain.Entities;
namespace PlanBetter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_courseService.GetCourses());

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var course = _courseService.GetCourse(id);
            if (course != null)
            {
                return Ok(course);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Add([FromBody] CourseModel model)
        {
            return CreatedAtAction(null, _courseService.AddCourse(model));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Course course)
        {
            _courseService.UpdateCourse(course);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseService.DeleteCourse(id);
            return NoContent();
        }
    }
}
