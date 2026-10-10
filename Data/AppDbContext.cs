
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Backend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public async Task<bool> CanConnectToDatabaseAsync()
    {
        return await Database.CanConnectAsync();
    }
}
