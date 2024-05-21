using Microsoft.AspNetCore.Mvc;

namespace Embagel.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
