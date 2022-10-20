using ApiRest.Models;
using Microsoft.EntityFrameworkCore;


namespace TodoManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        public DbSet<Post> Posts { get; set; }
    }
}
