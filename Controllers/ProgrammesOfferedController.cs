using College.DTO;
using College.Services.Context;
using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class ProgrammesOfferedController(ILogger<HomeController> logger, CLGDbContext db) : Controller
{
    public IActionResult ProgrammesOffered()
    {
        List<DepartmentsDTO> model = [];
        try
        {

        }
        catch (Exception ex)
        {

        }
        return View(model);
    }
}
