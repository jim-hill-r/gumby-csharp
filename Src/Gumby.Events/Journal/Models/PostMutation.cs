using System;
using System.Collections.Generic;

namespace Gumby.Mutation.Journal.Models
{
    public class PostMutation : IMutation
    {
        public Guid Id { get; set; }
        public MutationOperation Operation { get; set; }

        public IDictionary<string, string> Properties
        {
            get
            {
                var properties = new Dictionary<string, string>();
                return properties;
            }
        }
    }
}
