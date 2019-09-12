using System;
using System.Collections.Generic;
using System.Text;

namespace Gumby.Repository.Models
{
    public class Post
    {
        public string Text { get; set; }
        public IReadOnlyList<IDetail> Details { get; set; }
    }
}
