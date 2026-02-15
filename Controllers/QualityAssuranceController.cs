using College.Entities;
using College.Models;
using College.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace College.Controllers;

public class QualityAssuranceController(ILogger<HomeController> logger, CLGDbContext db) : Controller
{
    public async Task<IActionResult> AQAR()
    {
        List<AQARReport> model = [];
        try
        {
            model = await db.AQARReport.Where(x => x.Status).OrderBy(x => x.Order).ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading AQAR");
        }
        return View(model);
    }

    public async Task<IActionResult> IQAC()
    {
        IQACModel model = new();
        try
        {
            model.LstIQACMembers = await db.IQACMembers.Where(x => x.Status).OrderBy(x => x.Order).ToListAsync();
            model.LstIQACDocument = await db.IQACDocument.Where(x => x.Status).OrderBy(x => x.Order).ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading IQAC");
        }
        return View(model);
    }

    public async Task<IActionResult> NAC()
    {
        NACModel model = new();
        try
        {
            model.LstNACDetails = await db.NACDetails.Where(x => x.Status).OrderBy(x => x.Order).ToListAsync();
            model.LstNACDocument = await db.NACDocument.Where(x => x.Status).OrderBy(x => x.Order).ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading NAC");
        }
        return View(model);
    }

    public async Task<IActionResult> NIRF()
    {
        NIRFModel model = new();
        try
        {
            model.LstNIRFDetails = await db.NIRFDetails.Where(x => x.Status).OrderBy(x => x.Order).ToListAsync();
            model.LstNIRFDocument = await db.NIRFDocument.Where(x => x.Status).OrderBy(x => x.Year).ToListAsync();
            model.LstNIRFDocumentRanking = await db.NIRFDocumentRanking.Where(x => x.Status).OrderBy(x => x.Year).ToListAsync();

        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading NIRF");
        }
        return View(model);
    }
}
