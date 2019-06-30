using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gumby.Climb.Journal.Contract
{
    public interface IJournalService
    {
        Task<IEnumerable<IJournalData>> GetJournalsAsync(int count);
        Task<IJournalData> GetJournalAsync(Guid id);
        Task<Guid> CreateJournalAsync(IJournalData journal);
        Task<Guid> UpdateJournalAsync(IJournalData journal);
        Task<Guid> DeleteJournalAsync(Guid id);
    }
}
