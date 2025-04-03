using Microsoft.EntityFrameworkCore;

namespace Hello;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<TodoItem>()
            .Property(e => e.Priority)
            .HasMaxLength(255)
            .HasConversion(
                v => v.ToString(),
                v => v != null ? Enum.Parse<Priority>(v) : null);
    }
}

public class TodoItem
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public Priority? Priority { get; set; }
}

public enum Priority
{
    Low,
    Medium,
    High
}
