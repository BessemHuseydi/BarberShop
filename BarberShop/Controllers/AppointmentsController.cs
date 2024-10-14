using Microsoft.AspNetCore.Mvc;
using BarberShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace BarberShop.Controllers
{
    public class AppointmentsController : Controller
    {
        private static List<Appointment> _appointments = new List<Appointment>();

        public IActionResult Index()
        {
            return View(_appointments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _appointments.Add(appointment);
                return RedirectToAction("Index");
            }
            return View(appointment);
        }

        public IActionResult Cancel(int id)
        {
            var appointment = _appointments.FirstOrDefault(a => a.Id == id);
            if (appointment != null)
            {
                _appointments.Remove(appointment);
            }
            return RedirectToAction("Index");
        }
    }
}