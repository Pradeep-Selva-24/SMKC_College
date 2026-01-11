using Microsoft.AspNetCore.Mvc;

namespace College.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
