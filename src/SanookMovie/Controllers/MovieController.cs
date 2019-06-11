using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SanookMovie.Models;

namespace SanookMovie.Controllers {

    public class MovieController : Controller {

        static IList<Movie> _movies = new List<Movie>();

        public MovieController() { }

        public IActionResult Index() {
            return View(_movies);
        }
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie) {
            movie.Id = _movies.Count + 1;
            _movies.Add(movie);
            // return View();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id) {
            var movie = _movies.FirstOrDefault(x => x.Id == id);
            if (movie == null) return NotFound();
            return View(movie);
        }

        public IActionResult DeleteConfirm(int id) {
            var movie = _movies.FirstOrDefault(x => x.Id == id);
            if (movie == null) return NotFound();
            _movies.Remove(movie);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details() {
            return View();
        }

        public IActionResult Edit() {
            return View();
        }
    }
}