using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.App
{
    public interface IEndpointProvider
    {
        string GraphQLAPI { get; }
    }
}
