using Microsoft.EntityFrameworkCore;

namespace AliMertBayrak.Models
{
    public class BayrakContext : DbContext
    {
        public BayrakContext(DbContextOptions<BayrakContext> options)
            : base(options)
        {
        }

        public DbSet<Yorum> Yorumlar { get; set; }
    }
}

