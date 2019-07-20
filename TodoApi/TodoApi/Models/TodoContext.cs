using System;
using Microsoft.EntityFrameworkCore;


// add ad database context
namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base (options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
