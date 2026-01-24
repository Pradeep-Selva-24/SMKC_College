using College.Entities;
using College.Filters;
using College.Models;
using College.Services.Context;
using College.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace College.Controllers
{
    [AdminAuthorize]
    public class AdminController(ILogger<HomeController> logger, CLGDbContext db, IGenericRepository<PageMedia> repo, IWebHostEnvironment env) : Controller
    {
        private readonly IGenericRepository<PageMedia> _repo = repo;
        private readonly IWebHostEnvironment _env = env;
        private readonly string UploadImgPath = "/Uploads/Image";
        private readonly string UploadPdfPath = "/Uploads/PDF";

        public async Task<IActionResult> Dashboard()
        {
            DashboardModel model = new();
            try
            {
                List<CampusInfo> lstCampusInfo = await db.CampusInfo.Where(x => x.Status).ToListAsync();

                model.TotalStudents = lstCampusInfo.Where(x => x.Category == "Students").Select(x => x.Count).FirstOrDefault();
                model.Staff = lstCampusInfo.Where(x => x.Category == "Staff Members").Select(x => x.Count).FirstOrDefault();
                model.Departments = await db.DepartmentsMaster.CountAsync();
                model.LatestNews = await db.PageMedia.Where(x => x.Category == "Latest_News").CountAsync();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading Dashboard");
            }
            return View(model);
        }

        #region PageMedia
        public IActionResult PageMedia()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Banner(
        IFormFile bannerImage,
        string category,
        string heading,
        string shortContent,
        int displayOrder)
        {
            try
            {
                if (string.IsNullOrEmpty(category))
                    return Json(new { message = "Category is required" });

                if (bannerImage == null || bannerImage.Length == 0)
                    return Json(new { message = "Image upload failed" });

                var uploadPath = Path.Combine(_env.WebRootPath, UploadImgPath, "banners", category);
                Directory.CreateDirectory(uploadPath);

                var fileName = $"{Guid.NewGuid()}.jpg";
                var filePath = Path.Combine(uploadPath, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await bannerImage.CopyToAsync(stream);
                }

                var banner = new PageMedia
                {
                    Category = category,
                    ImagePath = $"{UploadImgPath}/banners/{category}/{fileName}",
                    Heading = heading,
                    ShortContent = shortContent,
                    DisplayOrder = displayOrder,
                    Date = DateTime.Now
                };

                await _repo.AddAsync(banner);
                await _repo.SaveAsync();

                return Json(new { message = "Banner uploaded successfully" });
            }
            catch
            {
                return Json(new { message = "Something went wrong while uploading" });
            }
        }
        #endregion

        #region Institution
        public IActionResult Institution()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetInstitution()
        {
            try
            {
                var lstInstitutionPages = await db.InstitutionPages.ToListAsync();
                return Json(lstInstitutionPages); // Return array directly
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetInstitution");
                return StatusCode(500, "Error loading data");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetInstitutionById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                InstitutionPages? InstitutionPages = await db.InstitutionPages.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (InstitutionPages != null)
                {
                    strResult = JsonConvert.SerializeObject(InstitutionPages);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetInstitution");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SaveInstitution([FromBody] InstitutionPages model)
        {
            string strMessage = "Failed";
            try
            {
                if (model.Id > 0) // Update
                {
                    var existing = await db.InstitutionPages.FindAsync(model.Id);
                    if (existing != null)
                    {
                        existing.PageType = model.PageType;
                        existing.Heading = model.Heading;
                        existing.Content = model.Content;
                        existing.ModifiedDate = DateTime.Now;

                        db.InstitutionPages.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                else // Insert
                {
                    model.CreatedDate = DateTime.Now;
                    db.InstitutionPages.Add(model);
                    await db.SaveChangesAsync();
                    strMessage = "Saved Successfully";
                }

                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving InstitutionPages");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateInstitution(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.InstitutionPages.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.InstitutionPages.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateInstitution");
                return Json(new { message = "Error" });
            }
        }
        #endregion


    }
}
