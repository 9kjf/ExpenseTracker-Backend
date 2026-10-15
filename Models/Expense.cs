
namespace ExpenseTracker.Backend.Models;

public class Expense
{
    public int Id { get; set; }
    public string UserId { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public decimal Amount { get; set; }

    public string Category { get; set; } = string.Empty;

    public DateTime Date { get; set; } = DateTime.UtcNow;

    public string? Notes { get; set; }

}
