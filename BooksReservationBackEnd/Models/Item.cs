using System.ComponentModel.DataAnnotations;

namespace BooksReservationBackEnd.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string PicUrl { get; set; }
        public decimal PricePerDay { get; set; }

        [Required(ErrorMessage = "You must specify if this is a book or an audiobook.")]
        public bool IsBook { get; set; }

        [Required(ErrorMessage = "You must specify if this is a book or an audiobook.")]
        public bool IsAudiobook { get; set; }

        public bool IsValid()
        {
            return IsBook || IsAudiobook;
        }
    }
}
