namespace BooksReservationBackEnd.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ItemNo { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public bool QuickPick { get; set; }
        public decimal Price { get; set; }

        public Item Item { get; set; }
    }
}
