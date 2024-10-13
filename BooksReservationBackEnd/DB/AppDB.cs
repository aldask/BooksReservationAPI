using Microsoft.EntityFrameworkCore;
using BooksReservationBackEnd.Models;

namespace BooksReservationBackEnd.DB
{
    public class AppDB : DbContext
    {
        public AppDB(DbContextOptions<AppDB> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
