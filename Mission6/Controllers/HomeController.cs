using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();

            return View("MovieForm", new Movie());
        }
        
        [HttpPost]
        public IActionResult MovieForm(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();
                return View("Index", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryId)
                    .ToList();
                return View("MovieForm", response);
            }
            
            
            

        }

        [HttpGet]
        public IActionResult MovieTable()
        {

            var movies = _context.Movies
                .Include("Category")
                .OrderBy(x => x.MovieId)
                .ToList();

            return View("MovieTable", movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var record = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();

            return View("MovieForm", record);
        }

        [HttpPost]
        public IActionResult Edit(Movie recordUpdated)
        {
            _context.Update(recordUpdated);
            _context.SaveChanges();

            return RedirectToAction("MovieTable");
        }
    }
}
