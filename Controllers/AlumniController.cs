using College.Entities;
using College.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace College.Controllers;

public class AlumniController(ILogger<HomeController> logger, CLGDbContext db) : Controller
{
    public async Task<IActionResult> Alumni()
    {
        List<PageMedia> model = [];
        try
        {
            model = await db.PageMedia.Where(x => x.Status && x.Category == "Alumni").OrderBy(x => x.DisplayOrder).ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading Alumni");
        }
        return View(model);
    }
}
