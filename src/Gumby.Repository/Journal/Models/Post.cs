using System.Collections.Generic;

namespace Gumby.Repository.Climb.Journal.Models
{
    public class Post
    {
        public string Text { get; set; }
        public IReadOnlyList<IDetail> Details { get; set; }
    }
}
