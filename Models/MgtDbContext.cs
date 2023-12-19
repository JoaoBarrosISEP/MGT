using Microsoft.EntityFrameworkCore;

namespace MGT.Models
{
    public class MgtDbContext : DbContext
    {
        public MgtDbContext()
        {
        }

        public MgtDbContext(DbContextOptions<MgtDbContext> options) : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
