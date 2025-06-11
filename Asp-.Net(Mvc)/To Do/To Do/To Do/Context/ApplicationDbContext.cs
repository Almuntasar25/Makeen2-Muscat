using Microsoft.EntityFrameworkCore;
using To_Do.Models;

namespace To_Do.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
