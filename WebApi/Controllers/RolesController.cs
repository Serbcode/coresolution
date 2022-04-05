using Microsoft.AspNetCore.Mvc;
using CoreSolution.Core.Domain;
using CoreSolution.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RolesContoller : ControllerBase
{
    private readonly ILogger<RolesContoller> logger;
    private readonly DataContext dbcontext;

    public RolesContoller(ILogger<RolesContoller> logger, DataContext dbcontext)
    {
        this.logger = logger;
        this.dbcontext = dbcontext;
    }    

    [HttpGet]
    public async Task<IEnumerable<Role>> GetAll()
    {
        return await dbcontext.Roles.AsNoTracking().ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Role>> GetRoleById(int id)
    {
        var role = await dbcontext.Roles.FirstOrDefaultAsync(r => r.RoleId == id);
        
        if (role == null)
        {
            logger.LogWarning("Role not found", id);
            return NotFound();
        }
        return Ok(role);
    }

}