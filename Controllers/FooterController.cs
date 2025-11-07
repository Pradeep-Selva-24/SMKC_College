using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class FooterController(ILogger<HomeController> logger) : Controller
{
    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Feedback()
    {
        return View();
    }

    public IActionResult PrivacyPolicy()
    {
        return View();
    }
}
