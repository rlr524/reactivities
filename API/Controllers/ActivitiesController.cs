using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class ActivitiesController : BaseAPIController
{
    private readonly DataContext _ctx;

    public ActivitiesController(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    [HttpGet] //api/v#/activities
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        return await _ctx.Activities.ToListAsync();
    }

    [HttpGet("{id}")] //api/v#/activities/{id}
    public async Task<ActionResult<Activity>> GetActivity(Guid id)
    {
        return await _ctx.Activities.FindAsync(id);
    }
}