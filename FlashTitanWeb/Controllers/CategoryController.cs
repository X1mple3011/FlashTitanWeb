using Microsoft.AspNetCore.Mvc;

namespace FlashTitanWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
