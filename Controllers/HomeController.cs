using Microsoft.AspNetCore.Mvc;

namespace DeepDiveIntoEnglishLanding.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}