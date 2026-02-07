using College.Entities;
using College.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace College.Controllers;

public class ProgrammesOfferedController(ILogger<HomeController> logger, CLGDbContext db) : Controller
{
    public async Task<IActionResult> ProgrammesOffered()
    {
        List<ProgrammesOffered> model = [];
        try
        {
            model = await db.ProgrammesOffered.Where(x => x.Status).OrderBy(x => x.Order).ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading ProgrammesOffered");
        }
        return View(model);
    }
}
