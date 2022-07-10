using Microsoft.AspNetCore.Mvc;
using MyHotel.Business.Models;
using MyHotel.Business.Services.IServices;
using MyHotel.Domain.Entities;

namespace MyHotel.Api.Controllers
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
