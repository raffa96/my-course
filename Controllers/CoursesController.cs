using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome to courses page!");
        }

        public IActionResult Detail(string id)
        {
            return Content($"Corso #{id}");
        }
    }
}