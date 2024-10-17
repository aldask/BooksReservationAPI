namespace BooksReservationBackEnd.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ? Name { get; set; }
        public int Year { get; set; }
        public string ? PicUrl { get; set; }
        public decimal PricePerDay { get; set; }
        public bool IsBook { get; set; }
        public bool IsAudiobook { get; set; }

        public bool IsValid()
        {
            return IsBook || IsAudiobook;
        }
    }
}