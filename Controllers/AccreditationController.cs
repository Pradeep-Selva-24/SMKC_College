using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class AccreditationController(ILogger<HomeController> logger) : Controller
{
    public IActionResult Accreditation()
    {
        return View();
    }
}
