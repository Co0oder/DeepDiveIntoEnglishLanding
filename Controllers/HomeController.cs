using DeepDiveIntoEnglishLanding.Interfaces;
using DeepDiveIntoEnglishLanding.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeepDiveIntoEnglishLanding.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGallery _gallery;
        private readonly IReviews _reviews;
        public HomeController(IGallery gallery, IReviews reviews)
        {
            _gallery = gallery;
            _reviews = reviews;
        }
        public IActionResult Index()
        {
            var gallery = _gallery.GetAllImages();
            var reviews = _reviews.GetRangeReviews(0, 3);
            var myModel = new IndexViewModel{Gallery = gallery, Reviews = reviews};
            return View(myModel);
        }
    }
}