using backend333.RequestModels;
using backend333.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend333.Controllers;
[ApiController]
[Route("[controller]")]

public class StoreController : ControllerBase
{
    private readonly DbContext333 _dbContext333;
    public StoreController(DbContext333 dbContext333)
    {
        _dbContext333 = dbContext333;
    }
    [HttpGet]
    public async Task<ActionResult<List<Store>>> Get()
    {
        var result = await _dbContext333.Store.ToListAsync();
        return (result);
    }
    [HttpPost(template:"StoreInput")]
    public async Task<ActionResult<Store>> StoreInput([FromBody] Store store)
    {
        if (ModelState.IsValid)
        {
            _dbContext333.Add(store);
            await _dbContext333.SaveChangesAsync();
            return Ok(new Success()
            {
                IsSuccessful = true
            });
        }
        return BadRequest();
    }
}