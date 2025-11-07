using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class HistoryController(ILogger<HomeController> logger) : Controller
{
    public IActionResult History()
    {
        return View();
    }
}
