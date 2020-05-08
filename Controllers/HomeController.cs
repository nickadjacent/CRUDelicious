using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private CRUDeliciousContext db;
        public HomeController(CRUDeliciousContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            List<Dish> allDishes = db.Dishes
                .ToList();

            return View(allDishes);
        }

        [HttpGet("/new")]
        public IActionResult AddDish()
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
