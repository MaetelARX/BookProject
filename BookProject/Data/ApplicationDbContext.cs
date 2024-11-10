using BookProject.Models;
using BookProject.Utilities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed genres
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, GenreName = "Action" },
                new Genre { Id = 2, GenreName = "Horror" },
                new Genre { Id = 3, GenreName = "Romance" },
                new Genre { Id = 4, GenreName = "Science" }
            );

            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/books");
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            var books = new[]
            {
            new { Id = 1, BookName = "Война и Мир", AuthorName = "Лев Толстой", Price = 20.50, GenreId = 3, Image = "war_and_peace.jpeg" },
            new { Id = 2, BookName = "Ана Каренина", AuthorName = "Лев Толстой", Price = 18.00, GenreId = 3, Image = "anna_karenina.jpg" },
            new { Id = 3, BookName = "Владетелят", AuthorName = "Николо Макиавели", Price = 15.00, GenreId = 1, Image = "the_prince.jpg" },
            new { Id = 4, BookName = "Нова земя", AuthorName = "Иван Вазов", Price = 12.50, GenreId = 3, Image = "new_earth.jpg" },
            new { Id = 5, BookName = "Държавата", AuthorName = "Платон", Price = 14.00, GenreId = 4, Image = "the_republic.jpg" },
            new { Id = 6, BookName = "Фауст", AuthorName = "Йохан Волфганг Гьоте", Price = 16.00, GenreId = 3, Image = "faust.jpg" },
            new { Id = 7, BookName = "Воля за власт", AuthorName = "Фридрих Ницше", Price = 17.50, GenreId = 4, Image = "will_to_power.jpg" },
            new { Id = 8, BookName = "Защо светът е такъв какъвто е", AuthorName = "Пол Кенеди", Price = 22.00, GenreId = 4, Image = "why_world_is.jpg" },
            new { Id = 9, BookName = "48-те закона на властта", AuthorName = "Робърт Грийн", Price = 19.00, GenreId = 1, Image = "48_laws_of_power.jpg" }
        };

            foreach (var book in books)
            {
                var originalFilePath = Path.Combine(uploadPath, book.Image);
                var resizedFilePath = Path.Combine(uploadPath, "resized_" + book.Image);

                if (File.Exists(originalFilePath) && !File.Exists(resizedFilePath))
                {
                    ImageResizer.ResizeImage(originalFilePath, resizedFilePath, 300, 450);
                }

                modelBuilder.Entity<Book>().HasData(new Book
                {
                    Id = book.Id,
                    BookName = book.BookName,
                    AuthorName = book.AuthorName,
                    Price = book.Price,
                    GenreId = book.GenreId,
                    Image = "/images/books/resized_" + book.Image
                });
            }
        }
    }
}
