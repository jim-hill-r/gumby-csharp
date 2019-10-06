using Gumby.Api.GraphQL.Journal.Models;
using System.Collections.Generic;

namespace Gumby.Api.GraphQL.Journal
{
    internal class JournalMutation
    {
        public Post CreatePost()
        {
            return new Post();
        }
    }
}
