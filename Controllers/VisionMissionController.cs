using College.Entities;
using College.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace College.Controllers;

public class VisionMissionController(ILogger<HomeController> logger, CLGDbContext db) : Controller
{
    public async Task<IActionResult> VisionMission()
    {
        List<InstitutionPages> model = [];
        try
        {
            model = await db.InstitutionPages.Where(x => x.PageType == "Vision_Mission").ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading Vision and Mission page");
        }

        return View(model);
    }
}
