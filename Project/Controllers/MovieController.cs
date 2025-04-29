using Microsoft.AspNetCore.Mvc;
using Project.DataAccess;
using Project.Models;
using System;

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
        public IActionResult Create() // GET: Show the form
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie) // POST: Save form
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}

