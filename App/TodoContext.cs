﻿using Microsoft.EntityFrameworkCore;

namespace Hello;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}

public class TodoItem
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public int Priority { get; set; }
}

public enum Priority
{
    Low,
    Medium,
    High
}
