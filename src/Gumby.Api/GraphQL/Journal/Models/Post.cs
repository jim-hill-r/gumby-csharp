using System;

namespace Gumby.Api.GraphQL.Journal.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
    }
}
