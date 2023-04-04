using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Layout_homework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}