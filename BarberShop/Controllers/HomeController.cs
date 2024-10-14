using BarberShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace BarberShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}