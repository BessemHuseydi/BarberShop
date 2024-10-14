using Microsoft.AspNetCore.Mvc;
using BarberShop.Models;
using System.Collections.Generic;

namespace BarberShop.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            var services = new List<Service>
            {
                new Service { Id = 1, Name = "Klasik Saç Kesimi", Price = 50 },
                new Service { Id = 2, Name = "Saç Düzleştirme", Price = 70 },
                new Service { Id = 3, Name = "Sakal Tasarımı", Price = 30 }
            };

            return View(services);
        }
    }
}