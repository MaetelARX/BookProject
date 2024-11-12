using Microsoft.AspNetCore.Mvc;

namespace BookProject.Controllers
{
    public class UserOrderController : Controller
    {
        public IActionResult UserOrders()
        {
            return View();
        }
    }
}
