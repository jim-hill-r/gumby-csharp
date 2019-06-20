using Gumby.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.Store.Route
{
    public class RouteState
    {
        public List<IRoute> Routes { get; private set; }

        public RouteState(List<IRoute> routes)
        {
            Routes = routes;
        }
    }
}
