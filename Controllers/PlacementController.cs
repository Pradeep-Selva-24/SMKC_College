using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class PlacementController(ILogger<HomeController> logger) : Controller
{
    public IActionResult Placement()
    {
        return View();
    }
}
