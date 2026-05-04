using Microsoft.AspNetCore.Mvc;

namespace FlashTitanWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
