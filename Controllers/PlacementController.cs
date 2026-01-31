using College.Models;
using College.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace College.Controllers;

public class PlacementController(ILogger<HomeController> logger, CLGDbContext db) : Controller
{
    public async Task<IActionResult> Placement()
    {
        PlacementModel Model = new();
        try
        {
            Model.OverallPlacementRate = await db.SettingMaster.Where(x => x.Status && x.Key == "Overall Placement Rate").Select(x => x.Value).FirstOrDefaultAsync();
            Model.CompaniesVisited = await db.SettingMaster.Where(x => x.Status && x.Key == "Companies Visited").Select(x => x.Value).FirstOrDefaultAsync();
            Model.StudentsPlaced = await db.SettingMaster.Where(x => x.Status && x.Key == "Students Placed").Select(x => x.Value).FirstOrDefaultAsync();
            Model.MoUsSigned = await db.SettingMaster.Where(x => x.Status && x.Key == "MoUs Signed").Select(x => x.Value).FirstOrDefaultAsync();
            Model.LstCompany = await db.PageMedia.Where(x => x.Status && x.Category == "Placement_Company").OrderBy(x => x.DisplayOrder).ToListAsync();
            Model.LstBanner = await db.PageMedia.Where(x => x.Status && x.Category == "Placement_Banner").OrderBy(x => x.DisplayOrder).ToListAsync();
            Model.LstPlacementContact = await db.PlacementContact.Where(x => x.Status).OrderBy(x => x.DisplayOrder).ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading Placement page");
        }
        return View(Model);
    }
}
