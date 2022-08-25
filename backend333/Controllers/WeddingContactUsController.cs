using backend333.RequestModels;
using backend333.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend333.Controllers;


[ApiController]
[Route("[controller]")]
public class WeddingContactUsController : ControllerBase
{
  private readonly DbContext333 _dbContextWedding;
  public WeddingContactUsController(DbContext333 dbContextWedding)
  {
    _dbContextWedding = dbContextWedding;
    _dbContextWedding.Database.EnsureCreated();
  }
  [HttpGet]
  public async Task<ActionResult<List<WeddingContactUs>>> Get()
  {
    var result = await _dbContextWedding.WeddingContactUs.ToListAsync();
    return Ok (result);
  }
  [HttpPost(template:"WeddingContactUsInput")]
  public  async Task<ActionResult<WeddingContactUs>> ContactUsInput([FromBody] WeddingContactUs contactUs)
  {
    if (ModelState.IsValid)
    {
      _dbContextWedding.Add(contactUs);
      await _dbContextWedding.SaveChangesAsync();
      return Ok(new Success()
      {
        IsSuccessful = true
      });
    }
    return BadRequest();
  }
}