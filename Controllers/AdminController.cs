using College.Entities;
using College.Models;
using College.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace College.Controllers
{
    public class AdminController(IGenericRepository<PageMedia> repo, IGenericRepository<MenuMaster> menuRepo, IWebHostEnvironment env) : Controller
    {
        private readonly IGenericRepository<PageMedia> _repo = repo;
        private readonly IGenericRepository<MenuMaster> _menuRepo = menuRepo;

        private readonly IWebHostEnvironment _env = env;


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

        // ✅ Menu Master Config Page
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

        // ✅ Toggle Enable/Disable (AJAX)
        [HttpPost]
        public async Task<IActionResult> ToggleMenu(int id, string display)
        {
            try
            {
                var menu = await _menuRepo.GetByIdAsync(id);
                if (menu == null)
                    return Json(new { success = false, message = "Menu not found" });

                // display value should be "Y" or "N"
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

    }
}
