using Microsoft.AspNetCore.Mvc;
using StajApp.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace StajApp.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            string correctEmail = "esra.kalkan1621@gmail.com";
            string correctPassword = "123456";

            if (email == correctEmail && password == correctPassword) {

                return RedirectToAction("Index");
        }
            else
            {
                ViewBag.Message = "Hatalı Giriş.";
             return View();
            }
           
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
