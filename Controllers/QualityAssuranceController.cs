using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class QualityAssuranceController(ILogger<HomeController> logger) : Controller
{
    public IActionResult AQAR()
    {
        return View();
    }

    public IActionResult IQAC()
    {
        return View();
    }

    public IActionResult NAC()
    {
        return View();
    }

    public IActionResult NIRF()
    {
        return View();
    }
}
