using Microsoft.AspNetCore.Mvc;

namespace SanookMovie.Controllers {

    public class MovieController : Controller {
        public IActionResult Index() {
            return View();
        }

    }
}