using Microsoft.AspNetCore.Mvc;
using Mission6.Models;
using System.Diagnostics;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private MovieCollectionContext _context;
        public HomeController(MovieCollectionContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutJoel()
        {
            return View("AboutJoel");
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View("MovieForm");
        }
        [HttpPost]
        public IActionResult MovieForm(Movie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Index", response);
        }
    }
}
