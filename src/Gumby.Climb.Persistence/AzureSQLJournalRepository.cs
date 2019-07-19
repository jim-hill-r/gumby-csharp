using Gumby.Climb.Journal.Contract;
using Gumby.Climb.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.Climb.Database
{
    public class AzureSQLJournalRepository : IJournalRepository, IDisposable
    {
        private readonly string CONN = "Server=tcp:gumbysql.database.windows.net,1433;Initial Catalog=gumbySQL;Persist Security Info=False;User ID=alexhonnold;Password=c53AE9c6E1AE95cD51B144F2A9E4A451;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private JournalContext _context;
        public AzureSQLJournalRepository(string dbConnectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<JournalContext>();
            optionsBuilder.UseSqlServer(CONN);
            _context = new JournalContext(optionsBuilder.Options);
        }
        
        public async Task<IEnumerable<JournalData>> GetManyAsync(int count)
        {
            return _context.Journals.OrderByDescending(j => j.OccurredAt).Take(count);
        }

        public async Task<JournalData> GetAsync(Guid id)
        {
            return _context.Journals.Find(id);
        }

        public async Task<Guid> CreateAsync(JournalData journal)
        {
            await _context.AddAsync(journal);
            await _context.SaveChangesAsync();
            return journal.Id;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
