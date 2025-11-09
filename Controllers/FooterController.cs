using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class FooterController(ILogger<HomeController> logger) : Controller
{
    public IActionResult PrivacyPolicy()
    {
        return View();
    }
}
