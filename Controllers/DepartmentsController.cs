using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class DepartmentsController(ILogger<HomeController> logger) : Controller
{
    [Route("Departments/{strDepartment}")]
    public IActionResult Departments(string strDepartment)
    {
        ViewBag.DepartmentName = strDepartment;
        return View();
    }
}
