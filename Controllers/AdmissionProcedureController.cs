using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class AdmissionProcedureController(ILogger<HomeController> logger) : Controller
{
    public IActionResult AdmissionProcedure()
    {
        return View();
    }
}
