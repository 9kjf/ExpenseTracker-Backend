
using ExpenseTracker.Backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DatabaseController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public DatabaseController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("test")]
    public async Task<IActionResult> TestConnection()
    {
        var connected = await _dbContext.CanConnectToDatabaseAsync();

        if (connected)
        {
            return Ok(new { message = "Database connection successful!" });
        }

        return StatusCode(503, new { message = "Database connection failed." });
    }
}
