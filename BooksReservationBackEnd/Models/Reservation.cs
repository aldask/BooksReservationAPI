using System.ComponentModel.DataAnnotations;

namespace BooksReservationBackEnd.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ItemNo { get; set; }
        public bool IsBook { get; set; }
        public bool IsAudiobook { get; set; }
        public int Duration { get; set; }
        public bool QuickPick { get; set; }
        public decimal Price { get; set; }
        public bool IsValid()
        {
            return IsBook || IsAudiobook;
        }
    }
}
