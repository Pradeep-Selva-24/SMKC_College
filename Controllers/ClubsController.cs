using College.Models;
using College.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace College.Controllers;

public class ClubsController(ILogger<HomeController> logger, CLGDbContext db) : Controller
{
    public async Task<IActionResult> Clubs()
    {
        ClubsModel model = new();
        try
        {
            model.LstClubsMaster = await db.ClubsMaster.Where(x => x.Status).OrderBy(x => x.DisplayOrder).ToListAsync();
            model.LstClubsDetails = await db.ClubsDetails.Where(x => x.Status).OrderBy(x => x.DisplayOrder).ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading Clubs");
        }
        return View(model);
    }
}
