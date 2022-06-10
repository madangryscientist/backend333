using backend333.RequestModels;
using backend333.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;
[ApiController]
[Route("[controller]")]
public class ContactUsController : ControllerBase
{
    [HttpPost(template:"ContactUsInput")]
    public  ActionResult<ContactUs> ContactUsInput([FromBody] ContactUs contactUs)
    {
        if (ModelState.IsValid)
        {
            return Ok(new Success()
            {
                IsSuccessful = true
            });
        }

        return BadRequest();
    }
}