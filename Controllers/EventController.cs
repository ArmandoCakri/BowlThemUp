using Microsoft.AspNetCore.Mvc;

namespace BowlThemUp.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult christmas()
        {
            return View();
        }
        public IActionResult Birthdays()
        {
            return View();
        }
        public IActionResult Business()
        {
            return View();
        }
    }
}
