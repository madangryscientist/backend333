using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;
[ApiController]
[Route("")]
public class HomeController : Controller
{
  [HttpGet]
  public string Index()
  {
    return "backend333";
  }
}