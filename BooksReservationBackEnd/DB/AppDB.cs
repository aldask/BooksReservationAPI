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
                new Item { Id = 1, Name = "C# in Depth", Year = 2019, PicUrl = "https://images.manning.com/book/f/0f9d189-3823-4078-ba3d-423f23172bd8/skeet3.png", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 2, Name = "Pro ASP.NET Core", Year = 2020, PicUrl = "https://images.manning.com/book/c/cfa8c6a-01a2-43d5-a812-8a6ebcc1c60d/Freeman-HI.png", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 3, Name = "Clean Code", Year = 2008, PicUrl = "https://m.media-amazon.com/images/I/51E2055ZGUL._UF1000,1000_QL80_.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 4, Name = "The Pragmatic Programmer", Year = 1999, PicUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSvpVYaJ2clBPnAgpBI_mfOrwMzbBfvB3M5bg&s", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 5, Name = "Design Patterns", Year = 1994, PicUrl = "https://m.media-amazon.com/images/I/81IGFC6oFmL._UF1000,1000_QL80_.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 6, Name = "Refactoring", Year = 1999, PicUrl = "https://m.media-amazon.com/images/I/71e6ndHEwqL.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 7, Name = "Introduction to Algorithms", Year = 2009, PicUrl = "https://m.media-amazon.com/images/I/61Pgdn8Ys-L._UF1000,1000_QL80_.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 8, Name = "Effective Java", Year = 2018, PicUrl = "https://m.media-amazon.com/images/I/7167aaVxs3L.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 9, Name = "JavaScript: The Good Parts", Year = 2008, PicUrl = "https://thumb.knygos-static.lt/TUSnTV-2dLiBxKDfjYH7UCVHEFg=/fit-in/800x800/filters:cwatermark(static/wm.png,500,75,30)/https://libri-media.knygos-static.lt/4b4b8abc-2d7b-4dc9-ba9e-4394125da841/1", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 10, Name = "You Don't Know JS: Scope & Closures", Year = 2014, PicUrl = "https://m.media-amazon.com/images/I/81zWsOMWE4L.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 11, Name = "Head First Design Patterns", Year = 2004, PicUrl = "https://m.media-amazon.com/images/I/91bobQSPQrL.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 12, Name = "Python Crash Course", Year = 2019, PicUrl = "https://thumb.knygos-static.lt/j9htg3TNVjUu45KZ61R07oUzUyg=/fit-in/800x800/filters:cwatermark(static/wm.png,500,75,30)/https://libri-media.knygos-static.lt/7e597e21-1fda-4fae-9285-8b40d50eee06/10", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 13, Name = "Eloquent JavaScript", Year = 2018, PicUrl = "https://eloquentjavascript.net/img/cover.jpg", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 14, Name = "The Clean Coder", Year = 2011, PicUrl = "https://thumb.knygos-static.lt/LJ3iIlLp6xe-2mUIy7sG3R0tXkc=/fit-in/800x800/filters:cwatermark(static/wm.png,500,75,30)/https://libri-media.knygos-static.lt/d90cb906-13ce-4377-bf78-6f87c7df8daf/6", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false },
                new Item { Id = 15, Name = "Agile Software Development", Year = 2002, PicUrl = "https://media.springernature.com/full/springer-static/cover-hires/book/978-3-642-12575-1", PricePerDay = 2.00m, IsBook = true, IsAudiobook = false }
            );
        }
    }
}