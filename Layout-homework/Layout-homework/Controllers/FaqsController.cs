using Microsoft.AspNetCore.Mvc;

namespace Layout_homework.Controllers
{
    public class FaqsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
