using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class AlumniController(ILogger<HomeController> logger) : Controller
{
    public IActionResult Alumni()
    {
        return View();
    }
}
