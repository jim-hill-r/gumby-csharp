using System;
using System.Collections.Generic;

namespace Gumby.Mutation
{
    public interface IMutation
    {
        Guid Id { get; set; }
        MutationOperation Operation { get; set; }
        IDictionary<string, string> Properties { get; }

    }
}
