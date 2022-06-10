using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;

public class ContactUsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}