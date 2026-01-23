using College.Entities;
using College.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace College.Controllers
{
    public class AdminController : Controller
    {
        private readonly IGenericRepository<PageMedia> _repo;
        private readonly IWebHostEnvironment _env;
        public AdminController(IGenericRepository<PageMedia> repo, IWebHostEnvironment env)
        {
            _repo = repo;
            _env = env;
        }
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("AdminUser") == null)
            {
                return RedirectToAction("Login", "Login");
            }

            return View();
        }
        public IActionResult Banner()
        {
            return View();
        }
        [HttpPost]
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

                // ✅ Category Folder Upload
                var uploadPath = Path.Combine(_env.WebRootPath, "uploads", "banners", category);
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
                    ImagePath = $"/uploads/banners/{category}/{fileName}",
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

    }
}
