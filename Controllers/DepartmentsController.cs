using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class DepartmentsController(ILogger<HomeController> logger) : Controller
{
    public IActionResult Departments()
    {
        return View();
    }
}
