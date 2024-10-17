using Microsoft.EntityFrameworkCore;
using BooksReservationBackEnd.Models;

namespace BooksReservationBackEnd.DB
{
    public class AppDB : DbContext
    {
        public AppDB(DbContextOptions<AppDB> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, Name = "C# in Depth", Year = 2019, PicUrl = "https://letsenhance.io/static/8f5e523ee6b2479e26ecc91b9c25261e/1015f/MainAfter.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 2, Name = "Pro ASP.NET Core", Year = 2020, PicUrl = "https://fps.cdnpk.net/images/home/subhome-ai.webp?w=649&h=649", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 3, Name = "Clean Code", Year = 2008, PicUrl = "https://letsenhance.io/static/8f5e523ee6b2479e26ecc91b9c25261e/1015f/MainAfter.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 4, Name = "The Pragmatic Programmer", Year = 1999, PicUrl = "https://fps.cdnpk.net/images/home/subhome-ai.webp?w=649&h=649", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 5, Name = "Design Patterns", Year = 1994, PicUrl = "https://letsenhance.io/static/8f5e523ee6b2479e26ecc91b9c25261e/1015f/MainAfter.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 6, Name = "Refactoring", Year = 1999, PicUrl = "https://letsenhance.io/static/8f5e523ee6b2479e26ecc91b9c25261e/1015f/MainAfter.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 7, Name = "Introduction to Algorithms", Year = 2009, PicUrl = "https://letsenhance.io/static/8f5e523ee6b2479e26ecc91b9c25261e/1015f/MainAfter.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 8, Name = "Effective Java", Year = 2018, PicUrl = "https://fps.cdnpk.net/images/home/subhome-ai.webp?w=649&h=649", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 9, Name = "JavaScript: The Good Parts", Year = 2008, PicUrl = "https://letsenhance.io/static/8f5e523ee6b2479e26ecc91b9c25261e/1015f/MainAfter.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 10, Name = "You Don't Know JS: Scope & Closures", Year = 2014, PicUrl = "https://fps.cdnpk.net/images/home/subhome-ai.webp?w=649&h=649", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 11, Name = "Head First Design Patterns", Year = 2004, PicUrl = "https://letsenhance.io/static/8f5e523ee6b2479e26ecc91b9c25261e/1015f/MainAfter.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 12, Name = "Python Crash Course", Year = 2019, PicUrl = "https://letsenhance.io/static/8f5e523ee6b2479e26ecc91b9c25261e/1015f/MainAfter.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 13, Name = "Eloquent JavaScript", Year = 2018, PicUrl = "https://fps.cdnpk.net/images/home/subhome-ai.webp?w=649&h=649", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 14, Name = "The Clean Coder", Year = 2011, PicUrl = "https://letsenhance.io/static/8f5e523ee6b2479e26ecc91b9c25261e/1015f/MainAfter.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 15, Name = "Agile Software Development", Year = 2002, PicUrl = "https://fps.cdnpk.net/images/home/subhome-ai.webp?w=649&h=649", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false }
            );
        }
    }
}