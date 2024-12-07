
using BookProject.Data;
using BookProject.Models;
using BookProject.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Security.Claims;

namespace BookProject.Tests.Tests
{
    public class CartRepositoryTests
    {
        private readonly ApplicationDbContext _context;
        private readonly Mock<UserManager<IdentityUser>> _mockUserManager;
        private readonly Mock<IHttpContextAccessor> _mockHttpContextAccessor;
        private readonly CartRepository _cartRepository;

        public CartRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new ApplicationDbContext(options);

            var store = new Mock<IUserStore<IdentityUser>>();
            _mockUserManager = new Mock<UserManager<IdentityUser>>(store.Object, null, null, null, null, null, null, null, null);
            _mockUserManager.Setup(x => x.GetUserId(It.IsAny<ClaimsPrincipal>()))
                .Returns("test-user-id");

            _mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            _mockHttpContextAccessor.Setup(x => x.HttpContext)
                .Returns(new DefaultHttpContext
                {
                    User = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, "test-user-id")
                    }))
                });
            _cartRepository = new CartRepository(_context, _mockUserManager.Object, _mockHttpContextAccessor.Object, true);
        }

        [Fact]
        public async Task AddItem_ShouldAddToCart()
        {
            var stock = new Stock
            {
                BookId = 1,
                Quantity = 10
            };
            var book = new Book
            {
                Id = 1,
                BookName = "Test Book",
                Price = 19.99d,
                AuthorName = "Random Avtor",
                Stock = stock
            };
            _context.Stocks.Add(stock);
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            var cartItemCount = await _cartRepository.AddItem(book.Id, 2);

            var cart = await _context.ShoppingCarts
                .Include(c => c.CartDetails)
                .ThenInclude(cd => cd.Book)
                .FirstOrDefaultAsync(c => c.UserId == "test-user-id");

            Assert.NotNull(cart);
            Assert.Single(cart.CartDetails);
            Assert.Equal(2, cart.CartDetails.First().Quantity); 
            Assert.Equal(1, cartItemCount);
        }
        [Fact]
        public async Task RemoveItem_ShouldDecreaseQuantityOrRemoveFromCart()
        {
            var book = new Book
            {
                Id = 1,
                BookName = "Testova Kniga",
                Price = 19.99,
                AuthorName = "Plamen Jelev"
            };

            var cart = new ShoppingCart
            {
                UserId = "test-user-id"
            };

            var cartDetail = new CartDetail
            {
                BookId = book.Id,
                Quantity = 2,
                ShoppingCart = cart,
                UnitPrice = book.Price
            };

            _context.Books.Add(book);
            _context.ShoppingCarts.Add(cart);
            _context.CartDetails.Add(cartDetail);
            await _context.SaveChangesAsync();

            var cartItemCount = await _cartRepository.RemoveItem(book.Id);

            var updatedCartDetail = await _context.CartDetails.FirstOrDefaultAsync(x => x.BookId == book.Id);
            Assert.NotNull(updatedCartDetail);
            Assert.Equal(1, updatedCartDetail.Quantity);
            Assert.Equal(1, cartItemCount);
        }

        [Fact]
        public async Task GetUserCart_ShouldReturnCartForCurrentUser()
        {
            var book = new Book
            {
                Id = 1,
                BookName = "Test Book",
                Price = 29.99d,
                AuthorName = "Test author"
            };

            var cart = new ShoppingCart
            {
                UserId = "test-user-id"
            };

            var cartDetail = new CartDetail
            {
                BookId = book.Id,
                Quantity = 2,
                ShoppingCart = cart,
                UnitPrice = book.Price
            };

            _context.Books.Add(book);
            _context.ShoppingCarts.Add(cart);
            _context.CartDetails.Add(cartDetail);
            await _context.SaveChangesAsync();

            var userCart = await _cartRepository.GetUserCart();

            Assert.NotNull(userCart);
            Assert.Equal("test-user-id", userCart.UserId);
            Assert.Single(userCart.CartDetails);
            Assert.Equal(2, userCart.CartDetails.First().Quantity);
        }

        [Fact]
        public async Task GetCartItemCount_ShouldReturnCorrectItemCount()
        {
            List<Book> books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    BookName = "test book 1",
                    Price = 199.99,
                    AuthorName = "Test author 1"
                },
                new Book
                {
                    Id = 2,
                    BookName = "test book 2",
                    Price = 140.99,
                    AuthorName = "Test author 2"
                }
            };

            ShoppingCart cart = new ShoppingCart
            {
                UserId = "test-user-id"
            };

            List<CartDetail> cartDetails = new List<CartDetail>
            {
                new CartDetail
                {
                    BookId = books[0].Id,
                    Quantity = 2,
                    ShoppingCart = cart,
                    UnitPrice = books[0].Price
                },
                new CartDetail
                {
                    BookId = books[1].Id,
                    Quantity = 5,
                    ShoppingCart = cart,
                    UnitPrice = books[1].Price
                }
            };

            _context.Books.AddRange(books);
            _context.ShoppingCarts.Add(cart);
            _context.CartDetails.AddRange(cartDetails);
            await _context.SaveChangesAsync();

            int itemCount = await _cartRepository.GetCartItemCount();

            Assert.Equal(2, itemCount);
        }
    }
}
