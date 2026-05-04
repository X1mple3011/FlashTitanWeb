using Microsoft.AspNetCore.Mvc;

namespace FlashTitanWeb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
