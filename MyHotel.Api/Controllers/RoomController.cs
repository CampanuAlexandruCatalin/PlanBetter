using Microsoft.AspNetCore.Mvc;
using PlanBetter.Business.Models;
using PlanBetter.Business.Services.IServices;
using PlanBetter.Domain.Entities;

namespace PlanBetter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_roomService.GetRooms());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var room = _roomService.GetRoom(id);
            if (room != null)
            {
                return Ok(room);
            }

            return NotFound();

        }

        [HttpPost]
        public IActionResult Add([FromBody] AddRoomModel model)
        {
            return CreatedAtAction(null, _roomService.AddRoom(model));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Room room)
        {
            _roomService.UpdateRoom(room);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _roomService.DeleteRoom(id);
            return NoContent();
        }
    }
}
