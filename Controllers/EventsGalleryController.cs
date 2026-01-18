using College.Entities;
using College.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace College.Controllers;

public class EventsGalleryController(ILogger<HomeController> logger, CLGDbContext db) : Controller
{
    public async Task<IActionResult> EventsGallery()
    {
        List<PageMedia> model = [];
        try
        {
            model = await db.PageMedia.Where(x => x.Status && x.Category == "Events").OrderBy(x => x.DisplayOrder).ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading Events Gallery");
        }
        return View(model);
    }
}
