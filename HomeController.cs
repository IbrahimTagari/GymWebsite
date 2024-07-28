using Microsoft.AspNetCore.Mvc;

namespace GymWorkoutRoutines.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
