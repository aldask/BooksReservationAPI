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

        [HttpPost("calc/{itemId}")]
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

            var reservation = new Reservation
            {
                Id = request.Id,
                Duration = request.Duration,
                QuickPick = request.QuickPick,
                Price = request.Price,
            };

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();

            return totalCost;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> GetReservation(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return reservation;
        }
    }
}