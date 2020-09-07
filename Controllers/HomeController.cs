using DeepDiveIntoEnglishLanding.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeepDiveIntoEnglishLanding.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGallery _gallery;
        public HomeController(IGallery gallery)
        {
            _gallery = gallery;
        }
        public IActionResult Index()
        {
            var images = _gallery.GetAllImages();
            return View(images);
        }
    }
}