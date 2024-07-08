using Microsoft.EntityFrameworkCore;
using TodoService.API.Models;

namespace TodoService.API.persistence;

public class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options) : base(options) { }

    public DbSet<TodoItem> Todos { get; set; } = null!;
}
