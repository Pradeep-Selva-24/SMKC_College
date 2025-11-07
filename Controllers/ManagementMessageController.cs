using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class ManagementMessageController(ILogger<HomeController> logger) : Controller
{
    public IActionResult ManagementMessage()
    {
        return View();
    }
}
