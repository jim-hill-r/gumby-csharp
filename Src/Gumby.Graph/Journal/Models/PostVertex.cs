using System;
using System.Collections.Generic;

namespace Gumby.Graph.Journal.Models
{
    public class PostVertex : IVertex
    {
        public Guid Id { get; set; }
        public string Label { get => "post"; }
        public string Partition { get => "journal"; }
        public string Text { get; set; }

        public IDictionary<string, string> Properties
        {
            get
            {
                var properties = new Dictionary<string, string>();
                properties.Add("text", Text);
                return properties;
            }
        }
    }
}
