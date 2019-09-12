using Gumby.Repository.Models;
using System.Collections.Generic;

namespace Gumby.Api.GraphQL
{
    internal class Query
    {
        public IReadOnlyList<Post> Posts { get; set; }
    }
}
