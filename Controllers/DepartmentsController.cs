using College.Entities;
using College.Models;
using College.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace College.Controllers;

public class DepartmentsController(ILogger<HomeController> logger, CLGDbContext db) : Controller
{
    public async Task<IActionResult> Departments()
    {
        List<DepartmentsMaster> model = [];
        try
        {
            model = await db.DepartmentsMaster.Where(x => x.Status).OrderBy(x => x.Order).ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading Departments");
        }
        return View(model);
    }

    [Route("DepartmentDetails/{DepartmentId}")]
    public async Task<IActionResult> DepartmentDetails(int DepartmentId)
    {
        DepartmentsModel model = new();
        try
        {
            model.DepartmentsMaster = await db.DepartmentsMaster.Where(x => x.Status && x.Id == DepartmentId).FirstOrDefaultAsync();
            model.LstDepartmentsMembers = await db.DepartmentsMembers.Where(x => x.Status && x.DepartmentsMasterId == DepartmentId).OrderBy(x => x.Order).ToListAsync();
            model.LstDepartmentsDetails = await db.DepartmentsDetails.Where(x => x.Status && x.DepartmentsMasterId == DepartmentId).OrderBy(x => x.DisplayOrder).ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading ProgrammesOffered");
        }
        return View(model);
    }
}
