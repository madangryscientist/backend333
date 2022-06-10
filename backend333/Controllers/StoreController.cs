using backend333.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;
[ApiController]
[Route("[controller]")]

public class StoreController : ControllerBase
{
    // GET
    [HttpPost(template:"StoreInput")]
    public ActionResult<Store> StoreInput([FromBody] Store store)
    {
        return Ok(store);
    }
}