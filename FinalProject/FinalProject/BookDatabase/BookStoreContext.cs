using FinalProject.BookDatabase.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.BookDatabase
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books {  get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers {  get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API

            modelBuilder.Entity<Book>()
           .HasMany(b => b.Categories)
           .WithMany(c => c.Books)
           .UsingEntity<Dictionary<string, object>>(
               "BookCategory",
               j => j.HasOne<Category>().WithMany().HasForeignKey("CategoryId"),
               j => j.HasOne<Book>().WithMany().HasForeignKey("BookId"),
               j =>
               {
                   j.HasKey("BookId", "CategoryId");
               });
            modelBuilder.Entity<Author>()
                .HasKey(a => a.AuthorId);

            modelBuilder.Entity<Book>()
                .HasKey(b => b.BookId);

            modelBuilder.Entity<Category>()
                .HasKey(c => c.CategoryId);

            modelBuilder.Entity<Publisher>()
                .HasKey(p => p.PublisherId);

            modelBuilder.Entity<Review>()
                .HasKey(p => p.ReviewId);

            modelBuilder.Entity<Author>()
                .Property(a => a.Name)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Publisher>()
                .Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryName)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Review>()
                .Property(r => r.ReviewerName)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

           modelBuilder.Entity<Book>()
                .HasOne(b => b.Publisher)
                .WithMany(p => p.Books)
                .HasForeignKey(b => b.PublisherId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Review>()
            .HasOne(r => r.Book)
            .WithMany(b => b.Reviews)
            .HasForeignKey(r => r.BookId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Book>()
            .HasIndex(b => b.ISBN)
            .IsUnique();

            var tolstoyId = Guid.NewGuid();
            var goetheId = Guid.NewGuid();
            var machiavelliId = Guid.NewGuid();
            var platoId = Guid.NewGuid();

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    AuthorId = tolstoyId,
                    Name = "Leo Tolstoy",
                    Bio = "Russian writer, author of 'War and Peace' and 'Anna Karenina'."
                },
                new Author
                {
                    AuthorId = goetheId,
                    Name = "Johann Wolfgang von Goethe",
                    Bio = "German writer and statesman, known for 'Faust'."
                },
                new Author
                {
                    AuthorId = machiavelliId,
                    Name = "Niccolò Machiavelli",
                    Bio = "Italian Renaissance diplomat, philosopher, and writer, best known for 'Il Principe'."
                },
                new Author
                {
                    AuthorId = platoId,
                    Name = "Plato",
                    Bio = "Ancient Greek philosopher, founder of the Academy in Athens, known for works like 'Republic'."
                }
            );
            var randomHouseId = Guid.NewGuid();
            var oxfordId = Guid.NewGuid();
            var penguinClassicsId = Guid.NewGuid();
            var cambridgeId = Guid.NewGuid();

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher
                {
                    PublisherId = randomHouseId,
                    Name = "Random House",
                    Address = "New York, USA"
                },
                new Publisher
                {
                    PublisherId = oxfordId,
                    Name = "Oxford University Press",
                    Address = "Oxford, UK"
                },
                new Publisher
                {
                    PublisherId = penguinClassicsId,
                    Name = "Penguin Classics",
                    Address = "London, UK"
                },
                new Publisher
                {
                    PublisherId = cambridgeId,
                    Name = "Cambridge University Press",
                    Address = "Cambridge, UK"
                }
            );
            var philosophyCategoryId = Guid.NewGuid();
            var classicLiteratureCategoryId = Guid.NewGuid();

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = philosophyCategoryId,
                    CategoryName = "Philosophy"
                },
                new Category
                {
                    CategoryId = classicLiteratureCategoryId,
                    CategoryName = "Classic Literature"
                }
            );
            var warAndPeaceId = Guid.NewGuid();
            var annaKareninaId = Guid.NewGuid();
            var faustId = Guid.NewGuid();
            var ilPrincipeId = Guid.NewGuid();
            var republicId = Guid.NewGuid();

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = warAndPeaceId,
                    Title = "War and Peace",
                    ISBN = "9780307266934",
                    PublishedDate = new DateTime(1869, 1, 1),
                    AuthorId = tolstoyId,
                    PublisherId = randomHouseId
                },
                new Book
                {
                    BookId = annaKareninaId,
                    Title = "Anna Karenina",
                    ISBN = "9780143035008",
                    PublishedDate = new DateTime(1877, 1, 1),
                    AuthorId = tolstoyId,
                    PublisherId = penguinClassicsId
                },
                new Book
                {
                    BookId = faustId,
                    Title = "Faust",
                    ISBN = "9780140449013",
                    PublishedDate = new DateTime(1808, 1, 1),
                    AuthorId = goetheId,
                    PublisherId = penguinClassicsId
                },
                new Book
                {
                    BookId = ilPrincipeId,
                    Title = "Il Principe",
                    ISBN = "9780199535699",
                    PublishedDate = new DateTime(1532, 1, 1),
                    AuthorId = machiavelliId,
                    PublisherId = oxfordId
                },
                new Book
                {
                    BookId = republicId,
                    Title = "Republic",
                    ISBN = "9780521484435",
                    PublishedDate = new DateTime(380, 1, 1),
                    AuthorId = platoId,
                    PublisherId = cambridgeId
                }
            );

            // Seed data for Reviews
            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    ReviewId = Guid.NewGuid(),
                    ReviewerName = "Alexander Ivanov",
                    Content = "A monumental work, Tolstoy's 'War and Peace' is unparalleled.",
                    Rating = 5,
                    BookId = warAndPeaceId
                },
                new Review
                {
                    ReviewId = Guid.NewGuid(),
                    ReviewerName = "Maria Petrova",
                    Content = "Tolstoy's 'Anna Karenina' is a beautiful tragedy.",
                    Rating = 5,
                    BookId = annaKareninaId
                },
                new Review
                {
                    ReviewId = Guid.NewGuid(),
                    ReviewerName = "Hans Müller",
                    Content = "Goethe's 'Faust' explores profound existential themes.",
                    Rating = 5,
                    BookId = faustId
                },
                new Review
                {
                    ReviewId = Guid.NewGuid(),
                    ReviewerName = "Lorenzo Rossi",
                    Content = "Machiavelli's 'Il Principe' is still relevant today in political philosophy.",
                    Rating = 4,
                    BookId = ilPrincipeId
                },
                new Review
                {
                    ReviewId = Guid.NewGuid(),
                    ReviewerName = "Sophia Demetriou",
                    Content = "Plato's 'Republic' is a cornerstone of Western philosophy.",
                    Rating = 5,
                    BookId = republicId
                }
            );

            modelBuilder.Entity("BookCategory").HasData(
                new { BookId = warAndPeaceId, CategoryId = classicLiteratureCategoryId },
                new { BookId = annaKareninaId, CategoryId = classicLiteratureCategoryId },
                new { BookId = faustId, CategoryId = classicLiteratureCategoryId },
                new { BookId = ilPrincipeId, CategoryId = philosophyCategoryId },
                new { BookId = republicId, CategoryId = philosophyCategoryId }
            );
        }
    }
}
