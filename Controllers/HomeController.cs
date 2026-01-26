using College.DTO;
using College.Entities;
using College.Models;
using College.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;

namespace College.Controllers;

public class HomeController(ILogger<HomeController> logger, CLGDbContext db) : Controller
{
    public async Task<IActionResult> Home()
    {
        HomeModel HomeModel = new();
        try
        {
            List<CampusInfo> lstCampusInfo = await db.CampusInfo.Where(x => x.Status).ToListAsync();
            List<PageMedia> lstPageMedia = await db.PageMedia.Where(x => x.Status).OrderBy(x => x.DisplayOrder).ToListAsync();

            string YearsOfExperience = FormatToK(lstCampusInfo.Where(x => x.Category == "Years Of Experience").Select(x => x.Count).FirstOrDefault());
            string Students = FormatToK(lstCampusInfo.Where(x => x.Category == "Students").Select(x => x.Count).FirstOrDefault());
            string StaffMembers = FormatToK(lstCampusInfo.Where(x => x.Category == "Staff Members").Select(x => x.Count).FirstOrDefault());

            HomeModel = new()
            {
                LstBanner = lstPageMedia.Where(x => x.Category == "Banner_Image").OrderBy(x => x.DisplayOrder).ToList(),
                YearsOfExperience = YearsOfExperience,
                Students = Students,
                StaffMembers = StaffMembers,
                LstManagementDTO = await GetManagementDTOList(),
                LstCampusLife = lstPageMedia.Where(x => x.Category == "Campus_Life").OrderBy(x => x.DisplayOrder).ToList(),
                LstSports = lstPageMedia.Where(x => x.Category == "Sports").OrderBy(x => x.DisplayOrder).ToList(),
                LstLatestNews = lstPageMedia.Where(x => x.Category == "Latest_News").OrderBy(x => x.DisplayOrder).ToList()
            };
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading Home page");
        }
        return View(HomeModel);
    }

    public IActionResult AccessDenied()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet("GetDefaultData")]
    public async Task<IActionResult> GetDefaultData()
    {
        List<MenuMaster> Menu = [];
        List<SettingMaster> Setting = [];
        try
        {
            Menu = await db.MenuMaster.Where(x => x.Status && x.Display == "Y").ToListAsync();
            Setting = await db.SettingMaster.Where(x => x.Status).ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading GetDefaultData");
        }
        return Json(new { Menu, Setting });
    }

    private async Task<List<ManagementDTO>> GetManagementDTOList()
    {
        try
        {
            var data = await (
                           from m in db.Management
                           where m.Status == true
                           join c in db.ManagementContent.Where(x => x.Status == true)
                               on m.Id equals c.ManagementId into contentGroup
                           orderby m.DisplayOrder
                           select new ManagementDTO
                           {
                               Management = m,
                               lstManagementContent = contentGroup.ToList()
                           }
                       ).ToListAsync();

            return data;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading GetManagementDTOList");
            return [];
        }
    }

    public static string FormatToK(long number)
    {
        if (number >= 1_000_000)
            return (number / 1_000_000D).ToString("0.#") + "M";

        if (number >= 1_000)
            return (number / 1_000D).ToString("0.#") + "K";

        return number.ToString();
    }

    [HttpGet]
    public async Task<IActionResult> GetPageMediaById(int Id)
    {
        string strResult = string.Empty, strMessage = "Failed";
        try
        {
            PageMedia? PageMedia = await db.PageMedia.Where(x => x.Id == Id).FirstOrDefaultAsync();

            if (PageMedia != null)
            {
                strResult = JsonConvert.SerializeObject(PageMedia);
                strMessage = "Success";
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while loading GetPageMediaById");
        }
        return Json(new { result = strResult, message = strMessage });
    }
}
