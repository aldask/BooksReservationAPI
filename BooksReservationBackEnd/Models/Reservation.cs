namespace BooksReservationBackEnd.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ItemNo { get; set; }
        public string? Name { get; set; }
        public Item? Item { get; set; }
        public int Duration { get; set; }
        public bool QuickPick { get; set; }
        public decimal Price { get; set; }
        public bool IsBook { get; set; }

        public bool IsValid()
        {
            return Item != null;
        }
    }
}