namespace FinalProject.BookDatabase.DbEntities
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public ICollection<Book> Books { get; set; } = null!;
    }
}
