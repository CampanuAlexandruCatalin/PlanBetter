using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotel.Business.Models;
using MyHotel.Business.Services;
using MyHotel.Business.Services.IServices;

namespace MyHotel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddReservation([FromBody] ReservationModel model)
        {
            var result = _reservationService.AddReservation(model);
            return CreatedAtAction(null, result);

        }

        [HttpPost("checkavailability")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CheckAvailability([FromBody] ReservationModel model)
        {
            var result = _reservationService.CheckReservation(model);
            return Ok(result);
        }
       
    }
}
