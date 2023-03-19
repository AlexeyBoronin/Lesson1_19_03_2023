using Microsoft.AspNetCore.Mvc;

namespace Lesson1_19_03_2023.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
