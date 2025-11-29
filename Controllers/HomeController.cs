using College.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace College.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    public IActionResult Home()
    {
        return View();
    }

    public IActionResult Management()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
