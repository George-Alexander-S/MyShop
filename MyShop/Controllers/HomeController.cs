using Microsoft.AspNetCore.Mvc;

namespace MyShop.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}