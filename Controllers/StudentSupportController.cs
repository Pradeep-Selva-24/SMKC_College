using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class StudentSupportController(ILogger<HomeController> logger) : Controller
{
    public IActionResult StudentSupport()
    {
        return View();
    }
}
