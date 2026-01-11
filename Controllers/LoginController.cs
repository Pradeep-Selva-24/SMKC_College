using Microsoft.AspNetCore.Mvc;

namespace College.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
}
