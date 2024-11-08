namespace FinalProject.BookDatabase.DbEntities
{
    public class Review
    {
        public Guid ReviewId { get; set; }
        public string ReviewerName { get; set; } = null!;
        public string Content { get; set; } = null!;
        public int Rating { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; } = null!;
    }
}
