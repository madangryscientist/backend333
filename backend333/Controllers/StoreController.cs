using backend333.DbModels;
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
    private readonly SlackService _slackService;

    public StoreController(DbContext333 dbContext333, SlackService slackService)
    {
        _dbContext333 = dbContext333;
        _slackService = slackService;
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
    [HttpPost(template:"TracksInput")]
    public async Task<ActionResult<Tracks>> TracksInput([FromBody] Tracks tracks)
    {
        if (ModelState.IsValid)
        {
            _dbContext333.Add(tracks);
            await _dbContext333.SaveChangesAsync();
            return Ok(new Success()
            {
                IsSuccessful = true
            });
        }
        return BadRequest();
    }

    [HttpGet(template: "TracksInput")]
    public async Task<List<Tracks>> TracksInput()
    {
        var result = await _dbContext333.Track.ToListAsync();
        return (result);
    }
    [HttpPost(template: "Test")]
    public async Task<ActionResult> Test([FromBody] StoreContactUs storeContactUs)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        var track = await _dbContext333.Track.FirstOrDefaultAsync(i => storeContactUs.TrackId == i.Id);
       if (track == null)
       {
           return NotFound();
       }
        var msg = new SlackMessage
        {
            channel = "wedding-rsvp",
            text = storeContactUs.Name + " " + storeContactUs.Email +" " + track.TrackName, 
            as_user = true,
        };
        await _slackService.PostAsync(msg);
        return Ok(new Success(){IsSuccessful = true});
    }

}