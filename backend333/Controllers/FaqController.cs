using backend333.RequestModels;
using backend333.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend333.Controllers;
[ApiController]
[Route("[controller]")]
public class FaqController  : ControllerBase
{
    private readonly DbContext333 _dbContext333;

    public FaqController(DbContext333 dbContext333)
    {
        _dbContext333 = dbContext333;
    }
    [HttpGet]
    public async Task<ActionResult<List<Faq>>> Get()
    {
        var result = await _dbContext333.Faqs.ToListAsync();
        return (result);
    }
        [HttpPost(template: "FaqInput")]
    public async Task<ActionResult<Faq>> FaqInput([FromBody] Faq faq)
    {
        if (ModelState.IsValid)
        {
            _dbContext333.Add(faq);
            await _dbContext333.SaveChangesAsync();
            return Ok(new Success()
            {
                IsSuccessful = true
            });
        }
        return BadRequest();
    }

    [HttpPost(template: "Approve")]
    public ActionResult<Success> Approve([FromBody] FaqActive faqActive)
    {
        var faqs = _dbContext333.Faqs.First(i => i.Id == faqActive.Id);
        faqs.Active = true;
        _dbContext333.SaveChanges();
        return Ok(new Success()
        {
            IsSuccessful = true
        });
    }
}
