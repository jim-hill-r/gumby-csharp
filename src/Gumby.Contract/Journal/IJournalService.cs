using Gumby.Contract.Journal;

namespace Gumby.Contract.Journal
{
    public interface IJournalService
    {
        IJournalData GetNewJournalDefault();
    }
}
