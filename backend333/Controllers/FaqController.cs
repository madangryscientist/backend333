using backend333.DbModels;
using backend333.RequestModels;
using backend333.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FaqActive = backend333.RequestModels.FaqActive;

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
        var result = await _dbContext333.Faqs.Where(i=>i.Active).ToListAsync();
        return (result);
    }
        [HttpPost(template: "FaqInput")]
    public async Task<ActionResult<Faq>> FaqInput([FromBody] FaqRequestModels faq)
    {
        if (ModelState.IsValid)
        {
            var model = new Faq()
            {
                Email = faq.Email,
                Name = faq.Name,
                Question = faq.Question
            };
            _dbContext333.Faqs.Add(model);
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
