
using ExpenseTracker.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Backend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Expense> Expenses { get; set; } = null!;

    public async Task<bool> CanConnectToDatabaseAsync()
    {
        return await Database.CanConnectAsync();
    }
}
