namespace BooksReservationBackEnd.Service
{
    public class ReserveCalc
    {
        private const decimal ItemPriceForDay = 2.0m;
        private const decimal AudioBookPriceForDay = 3.0m;
        private const decimal Fee = 3.0m;
        private const decimal QuickPickFee = 5.0m;

        public decimal ReserveSumCalc(string type, int days, bool quickPick)
        {
            decimal dailyPrice = type == "Book" ? ItemPriceForDay : AudioBookPriceForDay;

            decimal basePrice = dailyPrice * days;

            decimal discount = 0;
            if (days > 10)
            {
                discount = basePrice * 0.20m;
            }
            else if (days > 3)
            {
                discount = basePrice * 0.10m;
            }

            decimal totalPrice = basePrice - 0.10m + Fee;

            if (quickPick)
            {
                totalPrice += QuickPickFee;
            }

            return totalPrice;
        }
    }
}
