using Microsoft.EntityFrameworkCore;

namespace AliMertBayrak.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Yorum> Yorumlar { get; set; }
    }
}

