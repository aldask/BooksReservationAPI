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

        [HttpPost("calc/{id}")]
        public async Task<ActionResult<decimal>> CalculateReservation(int id, [FromBody] Reservation request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound("Item not found");
            }

            decimal totalCost = item.IsBook
                ? _reserveCalc.ReserveSumCalc(true, request.Duration, request.QuickPick)
                : _reserveCalc.ReserveSumCalc(false, request.Duration, request.QuickPick);

            var reservation = new Reservation
            {
                ItemNo = id,     
                Duration = request.Duration,
                QuickPick = request.QuickPick,
                Price = totalCost,
                IsBook = request.IsBook
            };

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();

            return totalCost;
        }

        [HttpGet("allreservations")]
        public ActionResult<List<Reservation>> GetCurrentReservations()
        {
            var reservations = _context.Reservations.ToList();
            return Ok(reservations);
        }
    }
}