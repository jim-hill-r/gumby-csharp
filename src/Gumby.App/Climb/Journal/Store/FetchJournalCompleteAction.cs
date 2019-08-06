using Gumby.Graph.Vertex.Climb.Journal;
using System.Collections.Generic;

namespace Gumby.App.Climb.Journal.Store
{
    public class FetchJournalCompleteAction
    {
        public readonly List<PostFull> Journals;

        public FetchJournalCompleteAction(List<PostFull> journals)
        {
            this.Journals = journals;
        }
    }
}
