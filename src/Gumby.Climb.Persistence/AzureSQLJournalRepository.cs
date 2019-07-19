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
        private JournalContext _context;
        public AzureSQLJournalRepository(string dbConnectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<JournalContext>();
            optionsBuilder.UseSqlServer(dbConnectionString);
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
