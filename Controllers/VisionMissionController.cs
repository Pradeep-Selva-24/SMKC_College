using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class VisionMissionController(ILogger<HomeController> logger) : Controller
{
    public IActionResult VisionMission()
    {
        return View();
    }
}
