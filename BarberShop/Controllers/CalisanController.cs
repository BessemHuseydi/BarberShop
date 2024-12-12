using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEB.Models;

namespace WEB.Controllers
{
    public class CalisanController : Controller
    {
        private readonly BerberContext _context;

        public CalisanController(BerberContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // Çalışanları Listeleme (Read)
        public IActionResult Index()
        {
            var calisanlar = _context.Calisanlar.Include(c => c.Salon).ToList(); // Salon ilişkisini dahil ediyoruz.
            return View(calisanlar);
        }

        // Çalışan Detayları (Read)
        public IActionResult Details(int id)
        {
            var calisan = _context.Calisanlar
                .Include(c => c.Salon)
                .FirstOrDefault(c => c.Id == id);

            if (calisan == null)
            {
                return NotFound();
            }

            return View(calisan);
        }

        // Yeni Çalışan Ekleme (Create)
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Salonlar = _context.Salonlar.ToList(); // Salonları dropdown için gönderiyoruz.
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Calisan model)
        {
            if (ModelState.IsValid)
            {
                _context.Calisanlar.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Salonlar = _context.Salonlar.ToList();
            //return View(model);
            return RedirectToAction("Create2");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create2(Calisan model)
        {
            if (ModelState.IsValid)
            {
                _context.Calisanlar.Add(model);
                _context.SaveChanges();

                // TempData ile başarılı kayıt mesajını saklıyoruz
                TempData["SuccessMessage"] = "Çalışan başarılı bir şekilde kaydedildi!";
                return RedirectToAction("Index");
            }

            // Model doğrulanmadıysa tekrar doldurma
            ViewBag.Salonlar = _context.Salonlar.ToList();
            return View(model);
        }


        // Çalışan Düzenleme (Update)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var calisan = _context.Calisanlar.Find(id);
            if (calisan == null)
            {
                return NotFound();
            }

            ViewBag.Salonlar = _context.Salonlar.ToList();
            return View(calisan);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Calisan model)
        {
            if (ModelState.IsValid)
            {
                _context.Calisanlar.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Salonlar = _context.Salonlar.ToList();
            return View(model);
        }

        // Çalışan Silme (Delete)
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var calisan = _context.Calisanlar.Find(id);
            if (calisan == null)
            {
                return NotFound();
            }

            _context.Calisanlar.Remove(calisan);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
