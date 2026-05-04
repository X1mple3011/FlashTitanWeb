using Microsoft.AspNetCore.Mvc;

namespace FlashTitanWeb.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
