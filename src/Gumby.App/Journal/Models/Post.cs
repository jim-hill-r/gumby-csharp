using System;
using System.Collections.Generic;

namespace Gumby.App.Journal.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTimeOffset OccurredAt { get; set; }
        public List<Detail> Details { get; set; }
    }
}
