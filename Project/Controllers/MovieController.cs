using Microsoft.AspNetCore.Mvc;
using Project.DataAccess;
using Project.Models;
using System;
using System.Linq;

namespace Project.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieContext _db;

        public MovieController(MovieContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Movie> objMoviesList = _db.Movies.ToList();
            return View(objMoviesList);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie) 
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost] 
        public IActionResult Delete(int id)
        {
            var movieToDelete = _db.Movies.Find(id);

            if (movieToDelete != null)
            {
                _db.Movies.Remove(movieToDelete);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
