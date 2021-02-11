using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantAssignment.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       
        //this is returning the array and going through each string and out[utting it.
        public IActionResult Index()
        {
            List<string> Foodie = new List<string>();

            foreach (FoodieList f in FoodieList.getFoodieList())
            {
                
                string? dish = f.FavDish ?? "It's all tasty!";
                Foodie.Add(string.Format($"#{f.Rank}: {f.RestName} <br> Favorite Dish: {dish} <br> Address: {f.Addy} <br> Phone #: {f.Phone} <br>  Website: <a href=\"https://www.walmart.com/\" >{f.Website}</a> "));


            }

            return View(Foodie);
        }
        [HttpGet]
        //this is getting and posting the user application
        public IActionResult UserApplication()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserApplication(UserList listResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddApplication(listResponse);
                return View("Confirmation", listResponse);
            }
            else
            {
                return View("UserApplication");
            }
        }
        //this is passing through the ienumerable tempstorage
        public IActionResult UserFoodieList()
        {
            return View(TempStorage.Applications);
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
