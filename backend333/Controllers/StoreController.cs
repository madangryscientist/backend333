using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;

public class StoreController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}