using Microsoft.AspNetCore.Mvc;

namespace Layout_homework.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
