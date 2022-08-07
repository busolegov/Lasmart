using Lasmart.DataService;
using Microsoft.EntityFrameworkCore;

namespace Lasmart.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            this.Init();
        }

        public DbSet<Point> Points { get; set; }
        public DbSet<Comment> Comments { get; set; }
        
    }
}
