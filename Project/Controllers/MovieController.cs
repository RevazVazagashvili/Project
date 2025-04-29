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

        public IActionResult Index()
        {
            List<Movie> objMoviesList = _db.Movies.ToList();
            return View(objMoviesList);
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}

