using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class ClubsController(ILogger<HomeController> logger) : Controller
{
    public IActionResult Clubs()
    {
        return View();
    }
}
