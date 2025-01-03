using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models // Replace with your actual namespace
{
    public class TaskManagementDbContext : DbContext
    {
        public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
    }
}
