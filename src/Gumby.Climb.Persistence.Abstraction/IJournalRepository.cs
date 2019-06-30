using Gumby.Climb.Journal.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gumby.Climb.Database
{
    public interface IJournalRepository
    {
        Task<IEnumerable<JournalData>> GetManyAsync(int count);
        Task<JournalData> GetAsync(Guid id);
        Task<Guid> CreateAsync(JournalData journal);
    }
}
