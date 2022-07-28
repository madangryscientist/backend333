using backend333.RequestModels;
using backend333.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend333.Controllers;
[ApiController]
[Route("[controller]")]

public class CommunityController : ControllerBase
{
    private readonly DbContext333 _dbContext333;
    public CommunityController(DbContext333 dbContext333)
    {
        _dbContext333 = dbContext333;
    }
    [HttpGet]
    public async Task<ActionResult<List<Community>>> Get()
    {
        var result = await _dbContext333.Community.Include(i=>i.Comment).ToListAsync();
        return Ok(result);
    }
    [HttpPost(template: "Community")]
    public async Task<ActionResult<Community>> CommunityInput([FromBody] Community community)
    {
        if (ModelState.IsValid)
        {
            _dbContext333.Add(community);
            await _dbContext333.SaveChangesAsync();
            return Ok(new Success()
            {
                IsSuccessful = true
            });
        }
        return BadRequest();
    }
    [HttpPost(template:"Approve")]

    public ActionResult<Success> Approve([FromBody] CommunityIdentity communityIdentity )
    {
       var comm= _dbContext333.Community.First(i => i.Id ==communityIdentity.Id );
       comm.Active = true;
       _dbContext333.SaveChanges();
       return Ok(new Success()
       {
           IsSuccessful = true
       });
    }

    [HttpPost(template: "Count")]
    public ActionResult<Success> Count([FromBody] CommunityIdentity community)
    {
        var comm = _dbContext333.Community.First(i => i.Id == community.Id);
        comm.Count++;
        _dbContext333.SaveChanges();
        return Ok(new Success()
        {
            IsSuccessful = true
        });
    }

    [HttpPost(template: "Comment")]
    public ActionResult<Success> Comment([FromBody] CommunityComment comment)
    {
        var comm = _dbContext333.Community
            .Include(i=>i.Comment)
            .First(i => i.Id == comment.CommunityId);
       comm.Comment.Add(comment);
        _dbContext333.SaveChanges();
        return Ok(new Success()
        {
            IsSuccessful = true
        });
    }
        
}