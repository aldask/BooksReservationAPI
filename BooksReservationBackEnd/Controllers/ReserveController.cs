using BooksReservationBackEnd.DB;
using BooksReservationBackEnd.Service;
using Microsoft.AspNetCore.Mvc;
using BooksReservationBackEnd.Models;

namespace BooksReservationBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReserveController : ControllerBase
    {
        private readonly ReserveCalc _reserveCalc;
        private readonly AppDB _context;

        public ReserveController(ReserveCalc reserveCalc, AppDB context)
        {
            _reserveCalc = reserveCalc;
            _context = context;
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<decimal>> CalculateReservation(int id, [FromBody] Reservation request)
        {
            if (request == null || !request.IsValid())
            {
                return BadRequest("Invalid reservation data");
            }

            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound("Item not found");
            }

            decimal totalCost = 0;

            if (item.IsBook)
            {
                totalCost = _reserveCalc.ReserveSumCalc(true, request.Duration, request.QuickPick);
            }
            else if (item.IsAudiobook)
            {
                totalCost = _reserveCalc.ReserveSumCalc(false, request.Duration, request.QuickPick);
            }

            return totalCost;
        }
    }
}