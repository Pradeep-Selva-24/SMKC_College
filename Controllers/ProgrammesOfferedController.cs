using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class ProgrammesOfferedController(ILogger<HomeController> logger) : Controller
{
    public IActionResult ProgrammesOffered()
    {
        return View();
    }
}
