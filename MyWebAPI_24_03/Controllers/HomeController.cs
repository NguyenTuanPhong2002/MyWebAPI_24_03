using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI_24_03.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
