using System;
using System.Collections.Generic;
using System.Text;

namespace Gumby.Graph
{
    public class GumbyGraphWriteQueryBuilder
    {
        List<IVertex> _verticiesToAdd = new List<IVertex>();
        public GumbyGraphWriteQueryBuilder AddVertex<T>(T vertex) where T : IVertex
        {
            _verticiesToAdd.Add(vertex);
            return this;
        }

        public IGumbyGraphWriteRequest Build()
        {
            var gumbyGraphWriteRequest = new GumbyGraphWriteRequest();
            foreach(var vertex in _verticiesToAdd)
            {
                gumbyGraphWriteRequest.AddObject(vertex);
            }
            return gumbyGraphWriteRequest;
        }
    }
}
