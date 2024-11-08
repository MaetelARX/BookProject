using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace FinalProject.BookDatabase.DbEntities
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Title { get; set; } = null!;
        public string ISBN { get; set; } = null!;
        public DateTime PublishedDate { get; set; }

        public Guid AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        public Guid PublisherId { get; set; }
        public Publisher Publisher { get; set; } = null!;

        public ICollection<Category> Categories { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;
    }
}
