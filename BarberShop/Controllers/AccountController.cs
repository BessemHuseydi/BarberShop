//// User Authentication Controller
//using Microsoft.AspNetCore.Mvc;

//using Microsoft.EntityFrameworkCore;

//using wepProgramingProject.Entity;

//namespace wepProgramingProject.Controllers
//{
//    public class AccountController : Controller
//    {
//        private readonly BerberContext _context;

//        public AccountController(BerberContext context)
//        {
//            _context = context;
//        }

//        // GET: Account/Login
//        public IActionResult Login()
//        {
//            return View();
//        }

//        // POST: Account/Login
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Login(string email, string password)
//        {
//            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
//            if (user == null)
//            {
//                ViewBag.ErrorMessage = "Invalid email or password.";
//                return View();
//            }

//            // Set user session or authentication logic here
//            TempData["User"] = user.Email;
//            return RedirectToAction("Index", "Home");
//        }

//        // GET: Account/SignUp
//        public IActionResult SignUp()
//        {
//            return View();
//        }

//        // POST: Account/SignUp
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> SignUp(User user)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View(user);
//            }

//            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
//            if (existingUser != null)
//            {
//                ViewBag.ErrorMessage = "Email is already registered.";
//                return View(user);
//            }

//            _context.Users.Add(user);
//            await _context.SaveChangesAsync();

//            return RedirectToAction("Login");
//        }

//        public IActionResult Logout()
//        {
//            // Clear session or authentication data
//            TempData["User"] = null;
//            return RedirectToAction("Login");
//        }
//    }
//}
