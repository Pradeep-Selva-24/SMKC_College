using College.Entities;
using College.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace College.Controllers
{
    public class LoginController(ILogger<HomeController> logger, IGenericRepository<Login> loginRepo) : Controller
    {
        public IActionResult Login()
        {
            try
            {
                var adminUser = HttpContext.Session.GetString("AdminUser");
                if (!string.IsNullOrEmpty(adminUser))
                {
                    return RedirectToAction("Dashboard", "Admin");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading Login");
            }
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

            var user = (await loginRepo.FindAsync(x =>
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
            loginRepo.Update(user);
            await loginRepo.SaveAsync();

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
