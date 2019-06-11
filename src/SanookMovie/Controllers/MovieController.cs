using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SanookMovie.Controllers {

    public class MovieController : Controller {

        IList<string> _movies = new List<string>();

        public MovieController() {
            _movies.Add("Titanic");
            _movies.Add("Avengers");
            _movies.Add("Alita");
        }

        public IActionResult Index() {
            return View(_movies);
        }

        public IActionResult Create() {
            return View();
        }

        public IActionResult Delete() {
            return View();
        }

    }
}