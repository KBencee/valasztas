using Microsoft.EntityFrameworkCore;
using ValasztasWebApp.Models;

namespace ValasztasWebApp.Data
{
    public class ValasztasDbContext : DbContext
    {
        public ValasztasDbContext(DbContextOptions<ValasztasDbContext> options) : base(options)
        {
            
        }

        public DbSet<Jelolt> Jeloltek { get; set; }
    }
}
