using College.Entities;
using College.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace College.Controllers
{
    public class LoginController : Controller
    {
        private readonly IGenericRepository<Login> _loginRepo;

        public LoginController(IGenericRepository<Login> loginRepo)
        {
            _loginRepo = loginRepo;
        }
        public IActionResult login()
        {
            return View();
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.Error = "Username and password are required";
                return View();
            }

            var user = (await _loginRepo.FindAsync(x =>
                        x.UserId == username &&
                        x.Password == password &&     // (hash later)
                        x.IsActive))
                        .FirstOrDefault();

            if (user == null)
            {
                ViewBag.Error = "Invalid username or password";
                return View();
            }

            // Update last login
            user.LastLogin = DateTime.Now;
            _loginRepo.Update(user);
            await _loginRepo.SaveAsync();

            // SESSION
            HttpContext.Session.SetString("AdminUser", user.UserId!);

            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
