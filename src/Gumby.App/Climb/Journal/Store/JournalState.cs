using Gumby.Graph.Vertex.Climb.Journal;
using System.Collections.Generic;

namespace Gumby.App.Climb.Journal.Store
{
    public class JournalState
    {
        public List<PostFull> Journals { get; private set; }

        public JournalState()
        {
            this.Journals = new List<PostFull>();
        }
        public JournalState(List<PostFull> journals)
        {
            Journals = journals;
        }
    }
}
