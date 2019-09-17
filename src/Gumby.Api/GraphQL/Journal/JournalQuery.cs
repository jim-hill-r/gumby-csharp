using Gumby.Api.GraphQL.Journal.Models;
using System.Collections.Generic;

namespace Gumby.Api.GraphQL.Journal
{
    internal class JournalQuery
    {
        public IReadOnlyList<Post> Posts { get; set; }
    }
}
