using College.Entities;
using College.Filters;
using College.Models;
using College.Services.Context;
using College.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Globalization;

namespace College.Controllers
{
    [AdminAuthorize]
    public class AdminController(ILogger<HomeController> logger, CLGDbContext db, IGenericRepository<PageMedia> repo, IGenericRepository<MenuMaster> menuRepo, IWebHostEnvironment env) : Controller
    {
        private readonly IGenericRepository<PageMedia> _repo = repo;
        private readonly IGenericRepository<MenuMaster> _menuRepo = menuRepo;

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
        public async Task<IActionResult> GetPageMedia(string Category)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                List<PageMedia> lstPageMedia = await db.PageMedia.Where(x => x.Category == Category).OrderBy(x => x.DisplayOrder).ToListAsync();

                if (lstPageMedia != null && lstPageMedia.Count > 0)
                {
                    strResult = JsonConvert.SerializeObject(lstPageMedia);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetPageMedia");
            }
            return Json(new { result = strResult, message = strMessage });
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
        public async Task<IActionResult> StatusUpdatePageMedia(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.PageMedia.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.PageMedia.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdatePageMedia");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SavePageMedia(int Id, IFormFile? bannerImage, string category, string heading, string shortContent, int displayOrder, string date)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(category))
                    return Json(new { message = "Category is required" });

                PageMedia? banner;
                if (Id > 0)
                {
                    banner = await db.PageMedia.FindAsync(Id);
                    if (banner == null)
                        return Json(new { message = "Record not found" });

                    if (bannerImage != null && bannerImage.Length > 0)
                    {
                        banner.ImagePath = await UploadImageAsync(bannerImage, category, banner.ImagePath!);
                    }

                    banner.Category = category;
                    banner.Heading = heading;
                    banner.ShortContent = shortContent;
                    if (DateTime.TryParseExact(date, "dd-mm-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        banner.Date = parsedDate;
                    }
                    else
                    {
                        banner.Date = null;
                    }
                    banner.DisplayOrder = displayOrder;
                    banner.ModifiedDate = DateTime.Now;

                    db.PageMedia.Update(banner);
                }
                else
                {
                    if (bannerImage == null || bannerImage.Length == 0)
                        return Json(new { message = "Image is required for new record" });

                    var imagePath = await UploadImageAsync(bannerImage, category, "");

                    banner = new PageMedia
                    {
                        Category = category,
                        ImagePath = imagePath,
                        Heading = heading,
                        ShortContent = shortContent,
                        DisplayOrder = displayOrder,
                        Date = DateTime.Now,
                        CreatedDate = DateTime.Now
                    };

                    if (DateTime.TryParseExact(date, "dd-mm-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        banner.Date = parsedDate;
                    }
                    else
                    {
                        banner.Date = null;
                    }

                    await db.PageMedia.AddAsync(banner);
                }

                await db.SaveChangesAsync();

                return Json(new { message = Id > 0 ? "Updated successfully" : "Uploaded successfully" });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving PageMedia");
                return Json(new { message = "Something went wrong while saving" });
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

        public IActionResult PlacementHighlights()
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

        #region Menu 

        public async Task<IActionResult> MenuMaster()
        {
            if (HttpContext.Session.GetString("AdminUser") == null)
                return RedirectToAction("Login", "Login");

            var menus = await _menuRepo.GetAllAsync();

            var list = menus
                .OrderBy(x => x.ParentMenuId)
                .ThenBy(x => x.Order)
                .Select(x => new MenuVM
                {
                    Id = x.Id,
                    ParentMenuId = x.ParentMenuId,
                    MenuName = x.MenuName ?? "",
                    MenuUrl = x.MenuUrl ?? "#",
                    Display = x.Display ?? "N",
                    Order = x.Order
                })
                .ToList();

            // Parent menus
            var parents = list.Where(x => x.ParentMenuId == null).ToList();

            // Attach children
            foreach (var p in parents)
                p.Children = list.Where(x => x.ParentMenuId == p.Id).OrderBy(x => x.Order).ToList();

            return View(parents);
        }

        [HttpPost]
        public async Task<IActionResult> ToggleMenu(int id, string display)
        {
            try
            {
                var menu = await _menuRepo.GetByIdAsync(id);
                if (menu == null)
                    return Json(new { success = false, message = "Menu not found" });

                menu.Display = display;

                _menuRepo.Update(menu);
                await _menuRepo.SaveAsync();

                return Json(new { success = true, message = "Menu updated successfully" });
            }
            catch
            {
                return Json(new { success = false, message = "Update failed" });
            }
        }

        #endregion

        #region Clubs Master

        public IActionResult ClubsMaster()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetClubsMaster()
        {
            try
            {
                var lstClubsMaster = await db.ClubsMaster.OrderBy(x => x.DisplayOrder).ToListAsync();
                return Json(lstClubsMaster);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetClubsMaster");
                return StatusCode(500, "Error loading data");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetClubsMasterById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                ClubsMaster? ClubsMaster = await db.ClubsMaster.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (ClubsMaster != null)
                {
                    strResult = JsonConvert.SerializeObject(ClubsMaster);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetClubsMasterById");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SaveClubsMaster([FromBody] ClubsMaster model)
        {
            string strMessage = "Failed";
            try
            {
                if (model.Id > 0) // Update
                {
                    var existing = await db.ClubsMaster.FindAsync(model.Id);
                    if (existing == null)
                    {
                        return Json(new { message = "Record not found" });
                    }
                    else if (existing != null)
                    {
                        existing.Clubs = model.Clubs;
                        existing.FullName = model.FullName;
                        existing.DisplayOrder = model.DisplayOrder;
                        existing.Description = model.Description;
                        existing.ModifiedDate = DateTime.Now;

                        db.ClubsMaster.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                else // Insert
                {
                    model.CreatedDate = DateTime.Now;
                    db.ClubsMaster.Add(model);
                    await db.SaveChangesAsync();
                    strMessage = "Saved Successfully";
                }

                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SaveClubsMaster");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateClubsMaster(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.ClubsMaster.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.ClubsMaster.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateClubsMaster");
                return Json(new { message = "Error" });
            }
        }
        #endregion

        #region Clubs Details

        public IActionResult ClubsDetails()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetlstClubs()
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                List<ClubsMaster> lstClubsMaster = await db.ClubsMaster.Where(x => x.Status).ToListAsync();

                if (lstClubsMaster != null)
                {
                    strResult = JsonConvert.SerializeObject(lstClubsMaster);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetlstClubs");
            }
            return Json(new { result = strResult, message = strMessage });
        }


        [HttpGet]
        public async Task<IActionResult> GetClubsDetails(int ClubsId, string Category)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                List<ClubsDetails> lstClubsDetails = await db.ClubsDetails.Where(x => x.ClubsMasterId == ClubsId && x.Category == Category).OrderBy(x => x.DisplayOrder).ToListAsync();

                if (lstClubsDetails != null && lstClubsDetails.Count > 0)
                {
                    strResult = JsonConvert.SerializeObject(lstClubsDetails);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetClubsDetails");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpGet]
        public async Task<IActionResult> GetClubsDetailsById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                ClubsDetails? ClubsDetails = await db.ClubsDetails.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (ClubsDetails != null)
                {
                    strResult = JsonConvert.SerializeObject(ClubsDetails);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetClubsDetailsById");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateClubsDetails(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.ClubsDetails.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.ClubsDetails.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateClubsDetails");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveClubsDetails(int Id, int ClubsId, IFormFile? bannerImage, string category, string heading, string shortContent, int displayOrder, string date)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(category))
                    return Json(new { message = "Category is required" });

                ClubsDetails? banner;
                if (Id > 0)
                {
                    banner = await db.ClubsDetails.FindAsync(Id);
                    if (banner == null)
                        return Json(new { message = "Record not found" });

                    if (bannerImage != null && bannerImage.Length > 0)
                    {
                        banner.ImagePath = await UploadImageAsync(bannerImage, category, banner.ImagePath!);
                    }

                    banner.Category = category;
                    banner.Heading = heading;
                    banner.ShortContent = shortContent;
                    banner.DisplayOrder = displayOrder;
                    banner.ModifiedDate = DateTime.Now;

                    db.ClubsDetails.Update(banner);
                }
                else
                {
                    if (bannerImage == null || bannerImage.Length == 0)
                        return Json(new { message = "Image is required for new record" });

                    var imagePath = await UploadImageAsync(bannerImage, category, "");

                    banner = new ClubsDetails
                    {
                        ClubsMasterId = ClubsId,
                        Category = category,
                        ImagePath = imagePath,
                        Heading = heading,
                        ShortContent = shortContent,
                        DisplayOrder = displayOrder,
                        CreatedDate = DateTime.Now
                    };

                    await db.ClubsDetails.AddAsync(banner);
                }

                await db.SaveChangesAsync();

                return Json(new { message = Id > 0 ? "Updated successfully" : "Uploaded successfully" });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SaveClubsDetails");
                return Json(new { message = "Something went wrong while saving" });
            }
        }

        #endregion

        #region Management Master
        public IActionResult ManagementMaster()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetManagement()
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                List<Management> lstManagement = await db.Management.OrderBy(x => x.DisplayOrder).ToListAsync();

                if (lstManagement != null && lstManagement.Count > 0)
                {
                    strResult = JsonConvert.SerializeObject(lstManagement);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetManagement");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpGet]
        public async Task<IActionResult> GetManagementById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                Management? Management = await db.Management.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (Management != null)
                {
                    strResult = JsonConvert.SerializeObject(Management);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetManagementById");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateManagement(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.Management.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.Management.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateManagement");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveManagement(int Id, IFormFile? bannerImage, string Name, string Designation, int displayOrder)
        {
            try
            {
                Management? banner;
                if (Id > 0)
                {
                    banner = await db.Management.FindAsync(Id);
                    if (banner == null)
                        return Json(new { message = "Record not found" });

                    if (bannerImage != null && bannerImage.Length > 0)
                    {
                        banner.ImagePath = await UploadImageAsync(bannerImage, "Management", banner.ImagePath!);
                    }

                    banner.Name = Name;
                    banner.Designation = Designation;
                    banner.DisplayOrder = displayOrder;
                    banner.ModifiedDate = DateTime.Now;

                    db.Management.Update(banner);
                }
                else
                {
                    if (bannerImage == null || bannerImage.Length == 0)
                        return Json(new { message = "Image is required for new record" });

                    var imagePath = await UploadImageAsync(bannerImage, "Management", "");

                    banner = new Management
                    {
                        ImagePath = imagePath,
                        Name = Name,
                        Designation = Designation,
                        DisplayOrder = displayOrder,
                        CreatedDate = DateTime.Now
                    };
                    await db.Management.AddAsync(banner);
                }

                await db.SaveChangesAsync();

                return Json(new { message = Id > 0 ? "Updated successfully" : "Uploaded successfully" });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving Management");
                return Json(new { message = "Something went wrong while saving" });
            }
        }

        #endregion

        #region Management Details
        public IActionResult ManagementDetails()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetlstManagement()
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                List<Management> lstManagement = await db.Management.Where(x => x.Status).ToListAsync();

                if (lstManagement != null)
                {
                    strResult = JsonConvert.SerializeObject(lstManagement);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetlstManagement");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpGet]
        public async Task<IActionResult> GetManagementContent()
        {
            try
            {
                var lstManagementContentPages = await db.ManagementContent.ToListAsync();

                var result = await (
                    from a in db.ManagementContent
                    join b in db.Management
                    on a.ManagementId equals b.Id
                    orderby b.DisplayOrder
                    select new
                    {
                        a.Id,
                        b.Name,          // S_Name
                        ManagementId = b.Id,
                        b.Designation,
                        b.ImagePath,
                        b.DisplayOrder,
                        a.Status,
                        a.Content
                    }
                    ).ToListAsync();


                return Json(result);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetManagementContent");
                return StatusCode(500, "Error loading data");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetManagementContentById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                ManagementContent? ManagementContent = await db.ManagementContent.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (ManagementContent != null)
                {
                    strResult = JsonConvert.SerializeObject(ManagementContent);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetManagementContent");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SaveManagementContent([FromBody] ManagementContent model)
        {
            string strMessage = "Failed";
            try
            {
                if (model.Id > 0) // Update
                {
                    var existing = await db.ManagementContent.FindAsync(model.Id);
                    if (existing == null)
                    {
                        return Json(new { message = "Record not found" });
                    }
                    else if (existing != null)
                    {
                        existing.Content = model.Content;
                        existing.ModifiedDate = DateTime.Now;

                        db.ManagementContent.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                else // Insert
                {
                    model.CreatedDate = DateTime.Now;
                    db.ManagementContent.Add(model);
                    await db.SaveChangesAsync();
                    strMessage = "Saved Successfully";
                }

                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving ManagementContentPages");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateManagementContent(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.ManagementContent.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.ManagementContent.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateManagementContent");
                return Json(new { message = "Error" });
            }
        }

        #endregion

        #region Departments Master

        public IActionResult DepartmentsMaster()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartmentsMaster()
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                List<DepartmentsMaster> lstDepartmentsMaster = await db.DepartmentsMaster.OrderBy(x => x.Order).ToListAsync();

                if (lstDepartmentsMaster != null && lstDepartmentsMaster.Count > 0)
                {
                    strResult = JsonConvert.SerializeObject(lstDepartmentsMaster);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetDepartmentsMaster");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartmentsMasterById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                DepartmentsMaster? DepartmentsMaster = await db.DepartmentsMaster.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (DepartmentsMaster != null)
                {
                    strResult = JsonConvert.SerializeObject(DepartmentsMaster);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetDepartmentsMasterById");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateDepartmentsMaster(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.DepartmentsMaster.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.DepartmentsMaster.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateDepartmentsMaster");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveDepartmentsMaster(int Id, IFormFile? bannerImage, string Department, string Description, int Order)
        {
            try
            {
                DepartmentsMaster? banner;
                if (Id > 0)
                {
                    banner = await db.DepartmentsMaster.FindAsync(Id);
                    if (banner == null)
                        return Json(new { message = "Record not found" });

                    if (bannerImage != null && bannerImage.Length > 0)
                    {
                        banner.ImagePath = await UploadImageAsync(bannerImage, "Departments", banner.ImagePath!);
                    }

                    banner.Department = Department;
                    banner.Description = Description;
                    banner.Order = Order;
                    banner.ModifiedDate = DateTime.Now;

                    db.DepartmentsMaster.Update(banner);
                }
                else
                {
                    if (bannerImage == null || bannerImage.Length == 0)
                        return Json(new { message = "Image is required for new record" });

                    var imagePath = await UploadImageAsync(bannerImage, "Departments", "");

                    banner = new DepartmentsMaster
                    {
                        ImagePath = imagePath,
                        Department = Department,
                        Description = Description,
                        Order = Order,
                        CreatedDate = DateTime.Now
                    };

                    await db.DepartmentsMaster.AddAsync(banner);
                }

                await db.SaveChangesAsync();

                return Json(new { message = Id > 0 ? "Updated successfully" : "Uploaded successfully" });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving DepartmentsMaster");
                return Json(new { message = "Something went wrong while saving" });
            }
        }
        #endregion

        #region Department Details

        public IActionResult DepartmentsDetails
            ()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetlstDepartment()
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                List<DepartmentsMaster> lstDepartmentsMaster = await db.DepartmentsMaster.Where(x => x.Status).ToListAsync();

                if (lstDepartmentsMaster != null)
                {
                    strResult = JsonConvert.SerializeObject(lstDepartmentsMaster);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetlstClubs");
            }
            return Json(new { result = strResult, message = strMessage });
        }


        [HttpGet]
        public async Task<IActionResult> GetDepartmentsDetails(int DepartmentId, string Category)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                List<DepartmentsDetails> lstDepartmentsDetails = await db.DepartmentsDetails.Where(x => x.DepartmentsMasterId == DepartmentId && x.Category == Category).OrderBy(x => x.DisplayOrder).ToListAsync();

                if (lstDepartmentsDetails != null && lstDepartmentsDetails.Count > 0)
                {
                    strResult = JsonConvert.SerializeObject(lstDepartmentsDetails);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetDepartmentsDetails");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartmentsDetailsById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                DepartmentsDetails? DepartmentsDetails = await db.DepartmentsDetails.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (DepartmentsDetails != null)
                {
                    strResult = JsonConvert.SerializeObject(DepartmentsDetails);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetDepartmentsDetailsById");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateDepartmentsDetails(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.DepartmentsDetails.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.DepartmentsDetails.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateDepartmentsDetails");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveDepartmentsDetails(int Id, int DepartmentId, IFormFile? bannerImage, string category, string heading, string shortContent, int displayOrder, string date)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(category))
                    return Json(new { message = "Category is required" });

                DepartmentsDetails? banner;
                if (Id > 0)
                {
                    banner = await db.DepartmentsDetails.FindAsync(Id);
                    if (banner == null)
                        return Json(new { message = "Record not found" });

                    if (bannerImage != null && bannerImage.Length > 0)
                    {
                        banner.ImagePath = await UploadImageAsync(bannerImage, category, banner.ImagePath!);
                    }

                    banner.Category = category;
                    banner.Heading = heading;
                    banner.ShortContent = shortContent;
                    banner.DisplayOrder = displayOrder;
                    banner.ModifiedDate = DateTime.Now;

                    db.DepartmentsDetails.Update(banner);
                }
                else
                {
                    if (bannerImage == null || bannerImage.Length == 0)
                        return Json(new { message = "Image is required for new record" });

                    var imagePath = await UploadImageAsync(bannerImage, category, "");

                    banner = new DepartmentsDetails
                    {
                        DepartmentsMasterId = DepartmentId,
                        Category = category,
                        ImagePath = imagePath,
                        Heading = heading,
                        ShortContent = shortContent,
                        DisplayOrder = displayOrder,
                        CreatedDate = DateTime.Now
                    };

                    await db.DepartmentsDetails.AddAsync(banner);
                }

                await db.SaveChangesAsync();

                return Json(new { message = Id > 0 ? "Updated successfully" : "Uploaded successfully" });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SaveDepartmentsDetails");
                return Json(new { message = "Something went wrong while saving" });
            }
        }

        #endregion

        #region Departments Members

        public IActionResult DepartmentsMembers()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartmentsMembers(int DepartmentId)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                List<DepartmentsMembers> lstDepartmentsMembers = await db.DepartmentsMembers.Where(x => x.DepartmentsMasterId == DepartmentId).OrderBy(x => x.Order).ToListAsync();

                if (lstDepartmentsMembers != null && lstDepartmentsMembers.Count > 0)
                {
                    strResult = JsonConvert.SerializeObject(lstDepartmentsMembers);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetDepartmentsMembers");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartmentsMembersById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                DepartmentsMembers? DepartmentsMembers = await db.DepartmentsMembers.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (DepartmentsMembers != null)
                {
                    strResult = JsonConvert.SerializeObject(DepartmentsMembers);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetDepartmentsMembersById");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateDepartmentsMembers(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.DepartmentsMembers.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.DepartmentsMembers.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateDepartmentsMembers");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveDepartmentsMembers(int Id, int DepartmentId, IFormFile? bannerImage, string Name, string Designation, int Order)
        {
            try
            {
                DepartmentsMembers? banner;
                if (Id > 0)
                {
                    banner = await db.DepartmentsMembers.FindAsync(Id);
                    if (banner == null)
                        return Json(new { message = "Record not found" });

                    if (bannerImage != null && bannerImage.Length > 0)
                    {
                        banner.ImagePath = await UploadImageAsync(bannerImage, "DepartmentsMembers", banner.ImagePath!);
                    }

                    banner.Name = Name;
                    banner.Designation = Designation;
                    banner.Order = Order;
                    banner.ModifiedDate = DateTime.Now;

                    db.DepartmentsMembers.Update(banner);
                }
                else
                {
                    //if (bannerImage == null || bannerImage.Length == 0)
                    //    return Json(new { message = "Image is required for new record" });

                    string imagePath = string.Empty;

                    if (bannerImage != null && bannerImage.Length == 0)
                    {
                        imagePath = await UploadImageAsync(bannerImage, "DepartmentsMembers", "");
                    }

                    banner = new DepartmentsMembers
                    {
                        DepartmentsMasterId = DepartmentId,
                        ImagePath = imagePath,
                        Name = Name,
                        Designation = Designation,
                        Order = Order,
                        CreatedDate = DateTime.Now
                    };

                    await db.DepartmentsMembers.AddAsync(banner);
                }

                await db.SaveChangesAsync();

                return Json(new { message = Id > 0 ? "Updated successfully" : "Uploaded successfully" });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SaveDepartmentsMembers");
                return Json(new { message = "Something went wrong while saving" });
            }
        }

        #endregion

        #region NAC Details

        public IActionResult NACDetails()
        {
            return View();
        }

        public async Task<IActionResult> GetNACDetails()
        {
            try
            {
                var lstNACDetails = await db.NACDetails.ToListAsync();
                return Json(lstNACDetails);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetNACDetails");
                return StatusCode(500, "Error loading data");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetNACDetailsById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                NACDetails? NACDetails = await db.NACDetails.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (NACDetails != null)
                {
                    strResult = JsonConvert.SerializeObject(NACDetails);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetNACDetails");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SaveNACDetails([FromBody] NACDetails model)
        {
            string strMessage = "Failed";
            try
            {
                if (model.Id > 0) // Update
                {
                    var existing = await db.NACDetails.FindAsync(model.Id);
                    if (existing == null)
                    {
                        return Json(new { message = "Record not found" });
                    }
                    else if (existing != null)
                    {
                        existing.Name = model.Name;
                        existing.Description = model.Description;
                        existing.Order = model.Order;
                        existing.ModifiedDate = DateTime.Now;

                        db.NACDetails.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                else // Insert
                {
                    model.CreatedDate = DateTime.Now;
                    db.NACDetails.Add(model);
                    await db.SaveChangesAsync();
                    strMessage = "Saved Successfully";
                }

                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SaveNACDetails");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateNACDetails(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.NACDetails.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.NACDetails.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateNACDetails");
                return Json(new { message = "Error" });
            }
        }
        #endregion

        #region NAC Documents

        public IActionResult NACDocument()
        {
            return View();
        }

        public async Task<IActionResult> GetNACDocument()
        {
            try
            {
                var lstNACDocument = await db.NACDocument.ToListAsync();
                return Json(lstNACDocument);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetNACDocument");
                return StatusCode(500, "Error loading data");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetNACDocumentById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                NACDocument? NACDocument = await db.NACDocument.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (NACDocument != null)
                {
                    strResult = JsonConvert.SerializeObject(NACDocument);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetNACDocument");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SaveNACDocument(int Id, string Name, int Order, IFormFile PdfFile)
        {
            string strMessage = "Failed";
            try
            {


                if (Id > 0) // Update
                {
                    var existing = await db.NACDocument.FindAsync(Id);
                    if (existing == null)
                    {
                        return Json(new { message = "Record not found" });
                    }
                    else if (existing != null)
                    {
                        existing.Name = Name;

                        if (PdfFile != null && PdfFile.Length > 0)
                        {
                            existing.Path = await UploadPdfAsync(PdfFile, "NACDocument", existing.Path!);
                        }

                        existing.Order = Order;
                        existing.ModifiedDate = DateTime.Now;

                        db.NACDocument.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                else // Insert
                {
                    if (PdfFile == null || PdfFile.Length == 0)
                    {
                        return Json(new { message = "Upload the pdf" });
                    }

                    NACDocument NACDocument = new()
                    {
                        Name = Name,
                        Path = await UploadPdfAsync(PdfFile, "NACDocument", ""),
                        Order = Order,
                        ModifiedDate = DateTime.Now
                    };

                    db.NACDocument.Add(NACDocument);
                    await db.SaveChangesAsync();
                    strMessage = "Saved Successfully";
                }

                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SaveNACDocument");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateNACDocument(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.NACDocument.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.NACDocument.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateNACDocument");
                return Json(new { message = "Error" });
            }
        }
        #endregion

        #region NIRF Details

        public IActionResult NIRFDetails()
        {
            return View();
        }

        public async Task<IActionResult> GetNIRFDetails()
        {
            try
            {
                var lstNIRFDetails = await db.NIRFDetails.ToListAsync();
                return Json(lstNIRFDetails);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetNIRFDetails");
                return StatusCode(500, "Error loading data");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetNIRFDetailsById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                NIRFDetails? NIRFDetails = await db.NIRFDetails.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (NIRFDetails != null)
                {
                    strResult = JsonConvert.SerializeObject(NIRFDetails);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetNIRFDetails");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SaveNIRFDetails([FromBody] NIRFDetails model)
        {
            string strMessage = "Failed";
            try
            {
                if (model.Id > 0) // Update
                {
                    var existing = await db.NIRFDetails.FindAsync(model.Id);
                    if (existing == null)
                    {
                        return Json(new { message = "Record not found" });
                    }
                    else if (existing != null)
                    {
                        existing.Name = model.Name;
                        existing.Description = model.Description;
                        existing.Order = model.Order;
                        existing.ModifiedDate = DateTime.Now;

                        db.NIRFDetails.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                else // Insert
                {
                    model.CreatedDate = DateTime.Now;
                    db.NIRFDetails.Add(model);
                    await db.SaveChangesAsync();
                    strMessage = "Saved Successfully";
                }

                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SaveNIRFDetails");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateNIRFDetails(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.NIRFDetails.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.NIRFDetails.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateNIRFDetails");
                return Json(new { message = "Error" });
            }
        }
        #endregion

        #region NIRF Document

        public IActionResult NIRFDocument()
        {
            return View();
        }

        public async Task<IActionResult> GetNIRFDocument()
        {
            try
            {
                var lstNIRFDocument = await db.NIRFDocument.ToListAsync();
                return Json(lstNIRFDocument);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetNIRFDocument");
                return StatusCode(500, "Error loading data");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetNIRFDocumentById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                NIRFDocument? NIRFDocument = await db.NIRFDocument.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (NIRFDocument != null)
                {
                    strResult = JsonConvert.SerializeObject(NIRFDocument);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetNIRFDocument");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SaveNIRFDocument(int Id, string Name, int Year, IFormFile PdfFile)
        {
            string strMessage = "Failed";
            try
            {


                if (Id > 0) // Update
                {
                    var existing = await db.NIRFDocument.FindAsync(Id);
                    if (existing == null)
                    {
                        return Json(new { message = "Record not found" });
                    }
                    else if (existing != null)
                    {
                        existing.Name = Name;
                        existing.Year = Year;

                        if (PdfFile != null && PdfFile.Length > 0)
                        {
                            existing.Path = await UploadPdfAsync(PdfFile, "NIRFDocument", existing.Path!);
                        }

                        existing.ModifiedDate = DateTime.Now;

                        db.NIRFDocument.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                else // Insert
                {
                    if (PdfFile == null || PdfFile.Length == 0)
                    {
                        return Json(new { message = "Upload the pdf" });
                    }

                    NIRFDocument NIRFDocument = new()
                    {
                        Name = Name,
                        Year = Year,
                        Path = await UploadPdfAsync(PdfFile, "NIRFDocument", ""),
                        ModifiedDate = DateTime.Now
                    };

                    db.NIRFDocument.Add(NIRFDocument);
                    await db.SaveChangesAsync();
                    strMessage = "Saved Successfully";
                }

                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SaveNIRFDocument");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateNIRFDocument(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.NIRFDocument.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.NIRFDocument.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateNIRFDocument");
                return Json(new { message = "Error" });
            }
        }
        #endregion

        #region NIRF Ranking

        public IActionResult NIRFDocumentRanking()
        {
            return View();
        }

        public async Task<IActionResult> GetNIRFDocumentRanking()
        {
            try
            {
                var lstNIRFDocumentRanking = await db.NIRFDocumentRanking.ToListAsync();
                return Json(lstNIRFDocumentRanking);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetNIRFDocumentRanking");
                return StatusCode(500, "Error loading data");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetNIRFDocumentRankingById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                NIRFDocumentRanking? NIRFDocumentRanking = await db.NIRFDocumentRanking.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (NIRFDocumentRanking != null)
                {
                    strResult = JsonConvert.SerializeObject(NIRFDocumentRanking);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetNIRFDocumentRanking");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SaveNIRFDocumentRanking([FromBody] NIRFDocumentRanking model)
        {
            string strMessage = "Failed";
            try
            {
                if (model.Id > 0) // Update
                {
                    var existing = await db.NIRFDocumentRanking.FindAsync(model.Id);
                    if (existing == null)
                    {
                        return Json(new { message = "Record not found" });
                    }
                    else if (existing != null)
                    {
                        existing.Year = model.Year;
                        existing.Category = model.Category;
                        existing.ParticipationStatus = model.ParticipationStatus;
                        existing.Score = model.Score;
                        existing.ModifiedDate = DateTime.Now;

                        db.NIRFDocumentRanking.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                else // Insert
                {
                    model.CreatedDate = DateTime.Now;
                    db.NIRFDocumentRanking.Add(model);
                    await db.SaveChangesAsync();
                    strMessage = "Saved Successfully";
                }

                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SaveNIRFDocumentRanking");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateNIRFDocumentRanking(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.NIRFDocumentRanking.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.NIRFDocumentRanking.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateNIRFDocumentRanking");
                return Json(new { message = "Error" });
            }
        }

        #endregion

        #region IQACMembers

        public IActionResult IQACMembers()
        {
            return View();
        }

        public async Task<IActionResult> GetIQACMembers()
        {
            try
            {
                var lstIQACMembers = await db.IQACMembers.ToListAsync();
                return Json(lstIQACMembers);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetIQACMembers");
                return StatusCode(500, "Error loading data");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetIQACMembersById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                IQACMembers? IQACMembers = await db.IQACMembers.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (IQACMembers != null)
                {
                    strResult = JsonConvert.SerializeObject(IQACMembers);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetIQACMembers");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SaveIQACMembers([FromBody] IQACMembers model)
        {
            string strMessage = "Failed";
            try
            {
                if (model.Id > 0) // Update
                {
                    var existing = await db.IQACMembers.FindAsync(model.Id);
                    if (existing == null)
                    {
                        return Json(new { message = "Record not found" });
                    }
                    else if (existing != null)
                    {
                        existing.Name = model.Name;
                        existing.Designation = model.Designation;
                        existing.Role = model.Role;
                        existing.Order = model.Order;
                        existing.ModifiedDate = DateTime.Now;

                        db.IQACMembers.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                else // Insert
                {
                    model.CreatedDate = DateTime.Now;
                    db.IQACMembers.Add(model);
                    await db.SaveChangesAsync();
                    strMessage = "Saved Successfully";
                }

                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SaveIQACMembers");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateIQACMembers(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.IQACMembers.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.IQACMembers.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateIQACMembers");
                return Json(new { message = "Error" });
            }
        }

        #endregion

        #region AQARReport

        public IActionResult AQARReport()
        {
            return View();
        }

        public async Task<IActionResult> GetAQARReport()
        {
            try
            {
                var lstAQARReport = await db.AQARReport.ToListAsync();
                return Json(lstAQARReport);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetAQARReport");
                return StatusCode(500, "Error loading data");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAQARReportById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                AQARReport? AQARReport = await db.AQARReport.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (AQARReport != null)
                {
                    strResult = JsonConvert.SerializeObject(AQARReport);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetAQARReport");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SaveAQARReport(int Id, string AcademicYear, string ReportTitle, int Order, IFormFile PdfFile)
        {
            string strMessage = "Failed";
            try
            {


                if (Id > 0) // Update
                {
                    var existing = await db.AQARReport.FindAsync(Id);
                    if (existing == null)
                    {
                        return Json(new { message = "Record not found" });
                    }
                    else if (existing != null)
                    {
                        existing.AcademicYear = AcademicYear;
                        existing.ReportTitle = ReportTitle;

                        if (PdfFile != null && PdfFile.Length > 0)
                        {
                            existing.FilePath = await UploadPdfAsync(PdfFile, "AQARReport", existing.FilePath!);
                        }

                        existing.Order = Order;
                        existing.ModifiedDate = DateTime.Now;

                        db.AQARReport.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                else // Insert
                {
                    if (PdfFile == null || PdfFile.Length == 0)
                    {
                        return Json(new { message = "Upload the pdf" });
                    }

                    AQARReport AQARReport = new()
                    {
                        AcademicYear = AcademicYear,
                        ReportTitle = ReportTitle,
                        FilePath = await UploadPdfAsync(PdfFile, "AQARReport", ""),
                        Order = Order,
                        ModifiedDate = DateTime.Now
                    };

                    db.AQARReport.Add(AQARReport);
                    await db.SaveChangesAsync();
                    strMessage = "Saved Successfully";
                }

                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SaveAQARReport");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateAQARReport(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.AQARReport.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.AQARReport.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateAQARReport");
                return Json(new { message = "Error" });
            }
        }
        #endregion

        #region PlacementContact

        public IActionResult PlacementContact()
        {
            return View();
        }

        public async Task<IActionResult> GetPlacementContact()
        {
            try
            {
                var lstPlacementContact = await db.PlacementContact.ToListAsync();
                return Json(lstPlacementContact);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetPlacementContact");
                return StatusCode(500, "Error loading data");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPlacementContactById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                PlacementContact? PlacementContact = await db.PlacementContact.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (PlacementContact != null)
                {
                    strResult = JsonConvert.SerializeObject(PlacementContact);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetPlacementContact");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SavePlacementContact([FromBody] PlacementContact model)
        {
            string strMessage = "Failed";
            try
            {
                if (model.Id > 0) // Update
                {
                    var existing = await db.PlacementContact.FindAsync(model.Id);
                    if (existing == null)
                    {
                        return Json(new { message = "Record not found" });
                    }
                    else if (existing != null)
                    {
                        existing.Name = model.Name;
                        existing.Email = model.Email;
                        existing.Phone = model.Phone;
                        existing.DisplayOrder = model.DisplayOrder;
                        existing.ModifiedDate = DateTime.Now;

                        db.PlacementContact.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                else // Insert
                {
                    model.CreatedDate = DateTime.Now;
                    db.PlacementContact.Add(model);
                    await db.SaveChangesAsync();
                    strMessage = "Saved Successfully";
                }

                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SavePlacementContact");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdatePlacementContact(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.PlacementContact.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.PlacementContact.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdatePlacementContact");
                return Json(new { message = "Error" });
            }
        }

        #endregion

        #region ProgrammesOffered

        public IActionResult ProgrammesOffered()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetProgrammesOffered(string Category)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                List<ProgrammesOffered> lstProgrammesOffered = await db.ProgrammesOffered.Where(x => x.Category == Category).OrderBy(x => x.Order).ToListAsync();

                if (lstProgrammesOffered != null && lstProgrammesOffered.Count > 0)
                {
                    strResult = JsonConvert.SerializeObject(lstProgrammesOffered);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetProgrammesOffered");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpGet]
        public async Task<IActionResult> GetProgrammesOfferedById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                ProgrammesOffered? ProgrammesOffered = await db.ProgrammesOffered.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (ProgrammesOffered != null)
                {
                    strResult = JsonConvert.SerializeObject(ProgrammesOffered);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetProgrammesOfferedById");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateProgrammesOffered(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.ProgrammesOffered.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.ProgrammesOffered.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateProgrammesOffered");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveProgrammesOffered(int Id, IFormFile? bannerImage, IFormFile PdfFile, string category, string Course, int Order, int StudentCount)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(category))
                    return Json(new { message = "Category is required" });

                ProgrammesOffered? banner;
                if (Id > 0)
                {
                    banner = await db.ProgrammesOffered.FindAsync(Id);
                    if (banner == null)
                        return Json(new { message = "Record not found" });

                    if (bannerImage != null && bannerImage.Length > 0)
                    {
                        banner.ImagePath = await UploadImageAsync(bannerImage, category, banner.ImagePath!);
                    }

                    if (PdfFile != null && PdfFile.Length > 0)
                    {
                        banner.SyllabusPath = await UploadPdfAsync(PdfFile, category, banner.SyllabusPath!);
                    }

                    banner.Category = category;
                    banner.Course = Course;
                    banner.StudentCount = StudentCount;
                    banner.Order = Order;
                    banner.ModifiedDate = DateTime.Now;

                    db.ProgrammesOffered.Update(banner);
                }
                else
                {
                    if (bannerImage == null || bannerImage.Length == 0)
                        return Json(new { message = "Image is required for new record" });

                    var imagePath = await UploadImageAsync(bannerImage, category, "");

                    string SyllabusPath = string.Empty;
                    if (PdfFile != null && PdfFile.Length > 0)
                    {
                        SyllabusPath = await UploadPdfAsync(PdfFile, category, "");
                    }


                    banner = new ProgrammesOffered
                    {
                        Category = category,
                        ImagePath = imagePath,
                        Course = Course,
                        SyllabusPath = SyllabusPath,
                        StudentCount = StudentCount,
                        Order = Order,
                        CreatedDate = DateTime.Now
                    };

                    await db.ProgrammesOffered.AddAsync(banner);
                }

                await db.SaveChangesAsync();

                return Json(new { message = Id > 0 ? "Updated successfully" : "Uploaded successfully" });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving ProgrammesOffered");
                return Json(new { message = "Something went wrong while saving" });
            }
        }
        #endregion

        #region CampusInfo
        public IActionResult CampusInfo()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetCampusInfo()
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                var lstCampusInfo = await db.CampusInfo.ToListAsync();
                if (lstCampusInfo != null && lstCampusInfo.Count > 0)
                {
                    strResult = JsonConvert.SerializeObject(lstCampusInfo);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetCampusInfo");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SaveCampusInfo([FromBody] List<CampusInfo> stats)
        {
            try
            {
                if (stats == null || !stats.Any())
                    return Json(new { message = "No data received" });

                foreach (var item in stats)
                {
                    var existing = await db.CampusInfo.FindAsync(item.Id);
                    if (existing == null)
                        continue; // Skip missing records

                    existing.Count = item.Count;
                    existing.ModifiedDate = DateTime.Now;

                    db.CampusInfo.Update(existing);
                }

                await db.SaveChangesAsync();

                return Json(new { message = "Success" });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving CampusInfo");
                return Json(new { message = "Error" });
            }
        }

        #endregion

        #region IQAC Documents

        public IActionResult IQACDocument()
        {
            return View();
        }

        public async Task<IActionResult> GetIQACDocument()
        {
            try
            {
                var lstIQACDocument = await db.IQACDocument.ToListAsync();
                return Json(lstIQACDocument);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetIQACDocument");
                return StatusCode(500, "Error loading data");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetIQACDocumentById(int Id)
        {
            string strResult = string.Empty, strMessage = "Failed";
            try
            {
                IQACDocument? IQACDocument = await db.IQACDocument.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (IQACDocument != null)
                {
                    strResult = JsonConvert.SerializeObject(IQACDocument);
                    strMessage = "Success";
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while loading GetIQACDocument");
            }
            return Json(new { result = strResult, message = strMessage });
        }

        [HttpPost]
        public async Task<IActionResult> SaveIQACDocument(int Id, string Name, int Order, IFormFile PdfFile)
        {
            string strMessage = "Failed";
            try
            {


                if (Id > 0) // Update
                {
                    var existing = await db.IQACDocument.FindAsync(Id);
                    if (existing == null)
                    {
                        return Json(new { message = "Record not found" });
                    }
                    else if (existing != null)
                    {
                        existing.Name = Name;

                        if (PdfFile != null && PdfFile.Length > 0)
                        {
                            existing.Path = await UploadPdfAsync(PdfFile, "IQACDocument", existing.Path!);
                        }

                        existing.Order = Order;
                        existing.ModifiedDate = DateTime.Now;

                        db.IQACDocument.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                else // Insert
                {
                    if (PdfFile == null || PdfFile.Length == 0)
                    {
                        return Json(new { message = "Upload the pdf" });
                    }

                    IQACDocument IQACDocument = new()
                    {
                        Name = Name,
                        Path = await UploadPdfAsync(PdfFile, "IQACDocument", ""),
                        Order = Order,
                        ModifiedDate = DateTime.Now
                    };

                    db.IQACDocument.Add(IQACDocument);
                    await db.SaveChangesAsync();
                    strMessage = "Saved Successfully";
                }

                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving SaveIQACDocument");
                return Json(new { message = "Error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> StatusUpdateIQACDocument(int? Id, bool IsStatus)
        {
            string strMessage = "Failed";
            try
            {
                if (Id != null && Id > 0) // Update
                {
                    var existing = await db.IQACDocument.FindAsync(Id);
                    if (existing != null)
                    {
                        existing.Status = IsStatus;
                        existing.ModifiedDate = DateTime.Now;
                        db.IQACDocument.Update(existing);
                        await db.SaveChangesAsync();
                        strMessage = "Updated Successfully";
                    }
                }
                return Json(new { message = strMessage });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving StatusUpdateIQACDocument");
                return Json(new { message = "Error" });
            }
        }
        #endregion

    }
}