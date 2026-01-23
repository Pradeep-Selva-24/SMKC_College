using College.Entities;
using College.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace College.Controllers;

public class StudentSupportController(ILogger<HomeController> logger, CLGDbContext db) : Controller
{
    public async Task<IActionResult> StudentSupport()
    {
        List<InstitutionPages> model = [];
        try
        {
            model = await db.InstitutionPages.Where(x => x.PageType == "Student_Support").ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading Vision and Mission page");
        }

        return View(model);
    }
}
