using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gumby.Graph
{
    public interface IGumbyGraphWriteRequest
    {
        IEnumerable<object> GetObjects();
    }
}
