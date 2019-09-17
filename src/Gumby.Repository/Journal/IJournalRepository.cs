using Gumby.Repository.Climb.Journal.Models;
using System.Collections.Generic;

namespace Gumby.Repository.Journal
{
    public interface IJournalRepository
    {
        IReadOnlyList<Post> GetPosts();
    }
}
