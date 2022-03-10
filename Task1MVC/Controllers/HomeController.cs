using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task1MVC.Models;

namespace Task1MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Employee emp = new Employee();
            emp.empID = 454;
            emp.empName = "Nitin";
            emp.empEmail = "Sharmanitin2246@gmail.com";

            return View(emp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}