using backend333.DbModels;
using backend333.RequestModels;
using backend333.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend333.Controllers;
[ApiController]
[Route("[controller]")]
public class ContactUsController : ControllerBase
{
    private readonly DbContext333 _dbContext333;
    public ContactUsController(DbContext333 dbContext333)
    {
        _dbContext333 = dbContext333;
        
    }
    [HttpGet]
    public async Task<ActionResult<List<ContactUs>>> Get()
    {
        var result = await _dbContext333.ContactUs.ToListAsync();
        return Ok (result);
    }
    [HttpPost(template:"ContactUsInput")]
    public  async Task<ActionResult<ContactUs>> ContactUsInput([FromBody] ContactUs contactUs)
    {
        if (ModelState.IsValid)
        {
            _dbContext333.Add(contactUs);
            await _dbContext333.SaveChangesAsync();
            return Ok(new Success()
            {
                IsSuccessful = true
            });
        }
        return BadRequest();
    }
}