using Gumby.Climb.Journal.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gumby.Climb.Database
{
    public interface IJournalRepository
    {
        Task<IEnumerable<IJournalData>> GetManyAsync(int count);
        Task<IJournalData> GetAsync(Guid id);
        Task<Guid> CreateAsync(IJournalData journal);
    }
}
