using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Familytree.Models;


namespace Familytree.Controllers
{
    public class HomeController : Controller
    {
        Repository repository = new Repository();
        public IActionResult Index()
        {
            var frederik = repository.DanishRoyalFamily[4];
            return View(frederik);
        }
       
        public IActionResult PersonSelected(int id)
        {
            var chosenPerson = repository.DanishRoyalFamily.FirstOrDefault(x => x.Id == id);
            return View("Index", chosenPerson);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
