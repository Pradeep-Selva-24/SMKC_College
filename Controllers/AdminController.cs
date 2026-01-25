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
        private readonly string UploadImgPath = "Uploads/Image";
        private readonly string UploadPdfPath = "Uploads/PDF";

        #region File & Image Upload
        private async Task<string> UploadPdfAsync(IFormFile file, string category, string existingFilePath)
        {
            if (file == null || file.Length == 0)
                throw new Exception("Please upload a PDF file");

            if (file.ContentType != "application/pdf")
                throw new Exception("Only PDF files are allowed");

            if (file.Length > 5 * 1024 * 1024)
                throw new Exception("PDF must be less than 5MB");

            // 🔹 Safe folder name
            var safeCategory = category.Trim().ToLower().Replace(" ", "_");

            // 🔹 Physical path
            var uploadPath = Path.Combine(_env.WebRootPath, UploadPdfPath, "SettingMaster", safeCategory);

            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            // 🔹 Delete old file
            if (!string.IsNullOrWhiteSpace(existingFilePath))
            {
                var oldFilePath = Path.Combine(_env.WebRootPath, existingFilePath.TrimStart('/').Replace("/", Path.DirectorySeparatorChar.ToString()));

                if (System.IO.File.Exists(oldFilePath))
                    System.IO.File.Delete(oldFilePath);
            }

            // 🔹 Save new file
            var fileName = $"{Guid.NewGuid()}.pdf";
            var fullPath = Path.Combine(uploadPath, fileName);

            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // 🔹 Return browser-friendly URL
            return $"/{UploadPdfPath}/SettingMaster/{safeCategory}/{fileName}";
        }

        private async Task<string> UploadImageAsync(IFormFile file, string category, string existingFilePath)
        {
            if (file == null || file.Length == 0)
                throw new Exception("Please upload an image file");

            // 🔹 Allowed image types
            var allowedTypes = new[] { "image/jpeg", "image/png", "image/webp", "image/jpg" };

            if (!allowedTypes.Contains(file.ContentType))
                throw new Exception("Only JPG, PNG, or WEBP images are allowed");

            if (file.Length > 5 * 1024 * 1024)
                throw new Exception("Image must be less than 5MB");

            // 🔹 Safe folder name
            var safeCategory = category.Trim().ToLower().Replace(" ", "_");

            // 🔹 Get file extension
            var extension = Path.GetExtension(file.FileName).ToLower();

            // 🔹 Physical path
            var uploadPath = Path.Combine(_env.WebRootPath, UploadImgPath, "SettingMaster", safeCategory);

            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            // 🔹 Delete old file
            if (!string.IsNullOrWhiteSpace(existingFilePath))
            {
                var oldFilePath = Path.Combine(
                    _env.WebRootPath,
                    existingFilePath.TrimStart('/')
                        .Replace("/", Path.DirectorySeparatorChar.ToString())
                );

                if (System.IO.File.Exists(oldFilePath))
                    System.IO.File.Delete(oldFilePath);
            }

            // 🔹 Save new image
            var fileName = $"{Guid.NewGuid()}{extension}";
            var fullPath = Path.Combine(uploadPath, fileName);

            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // 🔹 Return browser-friendly URL
            return $"/{UploadImgPath}/SettingMaster/{safeCategory}/{fileName}";
        }
        #endregion

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

        [HttpGet]
        public async Task<IActionResult> GetPageMedia()
        {
            try
            {
                var lstPageMediaPages = await db.PageMedia.ToListAsync();
                return Json(lstPageMediaPages);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetPageMedia");
                return StatusCode(500, "Error loading data");
            }
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

        [HttpPost]
        public async Task<IActionResult> SavePageMedia(
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

                string ImagePath = await UploadImageAsync(bannerImage, category, "");

                var banner = new PageMedia
                {
                    Category = category,
                    ImagePath = ImagePath,
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
                return Json(lstInstitutionPages);
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
                    if (existing == null)
                    {
                        return Json(new { message = "Record not found" });
                    }
                    else if (existing != null)
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

        #region Settings

        public IActionResult Settings()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetSettings()
        {
            try
            {
                var types = new[] { "Application", "Academic Calendar", "Examinations", "Results", "Running Text", "Courses Eligibility", "Fee Structure" };
                var lstSettingMaster = await db.SettingMaster.Where(x => types.Contains(x.Key)).ToListAsync();
                return Json(lstSettingMaster);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetSettings");
                return StatusCode(500, "Error loading data");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetSettingsById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                SettingMaster? SettingMaster = await db.SettingMaster.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (SettingMaster != null)
                {
                    strResult = JsonConvert.SerializeObject(SettingMaster);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetSettingsById");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SaveSettings(int Id, string Category, string Type, string Value, IFormFile PdfFile)
        {
            try
            {
                if (Id <= 0)
                    return Json(new { message = "Invalid request" });

                var existing = await db.SettingMaster.FindAsync(Id);
                if (existing == null)
                    return Json(new { message = "Record not found" });

                if (Type == "Pdf")
                {
                    existing.Value = await UploadPdfAsync(PdfFile, Category, existing.Value!);
                }
                else
                {
                    existing.Value = Value;
                }

                existing.ModifiedDate = DateTime.Now;

                db.SettingMaster.Update(existing);
                await db.SaveChangesAsync();

                return Json(new { message = "Updated Successfully" });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SettingMaster");
                return Json(new { message = "Error" });
            }
        }

        #endregion

        #region Placement Statistics
        public IActionResult PlacementStatistics()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetPlacementStatistics()
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                var types = new[] { "Overall Placement Rate", "Companies Visited", "Students Placed", "MoUs Signed" };
                var lstSettingMaster = await db.SettingMaster.Where(x => types.Contains(x.Key)).ToListAsync();
                if (lstSettingMaster != null && lstSettingMaster.Count > 0)
                {
                    strResult = JsonConvert.SerializeObject(lstSettingMaster);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetPlacementStatistics");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SavePlacementStatistics([FromBody] List<SettingMaster> stats)
        {
            try
            {
                if (stats == null || !stats.Any())
                    return Json(new { message = "No data received" });

                foreach (var item in stats)
                {
                    var existing = await db.SettingMaster.FindAsync(item.Id);
                    if (existing == null)
                        continue; // Skip missing records

                    existing.Value = item.Value;
                    existing.ModifiedDate = DateTime.Now;

                    db.SettingMaster.Update(existing);
                }

                await db.SaveChangesAsync();

                return Json(new { message = "Success" });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving Placement Statistics");
                return Json(new { message = "Error" });
            }
        }
        #endregion
    }
}
