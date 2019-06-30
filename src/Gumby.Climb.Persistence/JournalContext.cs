using Gumby.Climb.Journal.Contract;
using Microsoft.EntityFrameworkCore;

namespace Gumby.Climb.Persistence
{
    public class JournalContext : DbContext
    {
        public JournalContext(DbContextOptions<JournalContext> options) : base(options)
        {
        }
        public DbSet<JournalData> Journals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Climb");
        }
    }
}
