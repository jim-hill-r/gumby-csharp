using System;
using System.Collections.Generic;
using System.Text;

namespace Gumby.Graph
{
    public class GumbyGraphWriteQueryBuilder
    {
        public GumbyGraphWriteQueryBuilder AddVertex<T>(T vertex) where T : IVertex
        {
            
            return this;
        }

        public IGumbyGraphWriteRequest Build()
        {
            return new GumbyGraphWriteRequest();
        }
    }
}
