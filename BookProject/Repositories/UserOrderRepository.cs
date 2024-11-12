﻿using BookProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookProject.Repositories
{
    public class UserOrderRepository : IUserOrderRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;
        public UserOrderRepository(ApplicationDbContext db, IHttpContextAccessor httpContextAccessor
            ,UserManager<IdentityUser> userManager) 
        {
            _httpContextAccessor = httpContextAccessor;
            _db = db;
            _userManager = userManager;
        }
        public async Task<IEnumerable<Order>> UserOrders()
        {
            var userId = GetUserId();
            if (string.IsNullOrEmpty(userId))
            {
                throw new Exception("User is not logged-in");
            }
            var orders = await _db.Orders
                .Include(x=>x.OrderDetail)
                .ThenInclude(x=>x.Book)
                .ThenInclude(x=>x.Genre)
                .Where(a=>a.UserId==userId)
                .ToListAsync();

            return orders;
        }
        private string GetUserId()
        {
            var principal = _httpContextAccessor.HttpContext.User;
            string userId = _userManager.GetUserId(principal);
            return userId;
        }
    }
}
