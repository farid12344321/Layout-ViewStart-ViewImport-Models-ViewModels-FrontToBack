using Layout_practica.Models;
using Layout_practica.ViewModels.Home;
using Layout_practica.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace Layout_practica.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["names"] = new string[] { "Elcan", "Pervin", "Aqshin" };

            //ViewBag.numbers = new int[] { 10, 20, 30, 40 };

            //ViewBag.name = "Elcan";

            //TempData["surname"] = "Qurbanov";

            //return RedirectToAction(nameof(Detail));

            //string name = "Xaker"; 

            Student stu1 = new()
            {
                İd = 1,
                FullName = "pervin rehimli",
                Age = 26,
            };

            Student stu2 = new()
            {
                İd = 2,
                FullName = "ali talibov",
                Age = 21,
            };

            Student stu3 = new()
            {
                İd = 3,
                FullName = "mirze besirli",
                Age = 27,
            };

            List<Student> students = new List<Student>() { stu1, stu2, stu3 };



            Product product = new()
            {
                Id = 1,
                Name = "Samsung 11",
                Count= 50,
                Price= 200,
                Description = "Description"
            };

            ProductVm productVm = new()
            {
                Name = product.Name,
                Price = product.Price,

            };


            HomeVM mode1 = new()
            {
                Students= students,
                Product= productVm,
            };

            return View(mode1);
        }

        //public IActionResult Detail()
        //{
        //    return View();
        //}
    }
}
