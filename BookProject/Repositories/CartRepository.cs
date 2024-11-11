namespace BookProject.Repositories
{
    public class CartRepository
    {
        private readonly ApplicationDbContext _db;
        public CartRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void AddItem()
        {

        }
    }
}
