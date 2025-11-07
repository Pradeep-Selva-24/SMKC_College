using Microsoft.AspNetCore.Mvc;

namespace College.Controllers;

public class EventsGalleryController(ILogger<HomeController> logger) : Controller
{
    public IActionResult EventsGallery()
    {
        return View();
    }
}
