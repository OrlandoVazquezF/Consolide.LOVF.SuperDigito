using Consolide.LOVF.SuperDigito.Models;
using Microsoft.EntityFrameworkCore;

namespace Consolide.LOVF.SuperDigito.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasNoKey();
            modelBuilder.Entity<Historial>().HasNoKey();
        }

        public DbSet<User> User { get; set; }
        public DbSet<Historial> Historial { get; set; }
    }
}
