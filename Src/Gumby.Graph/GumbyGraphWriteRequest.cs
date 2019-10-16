using System;
using System.Collections.Generic;
using System.Text;

namespace Gumby.Graph
{
    public class GumbyGraphWriteRequest : IGumbyGraphWriteRequest
    {
        List<object> _objects = new List<object>();
        public void AddObject(object o)
        {
            _objects.Add(o);
        }
        public IEnumerable<object> GetObjects()
        {
            return _objects;
        }
    }
}
