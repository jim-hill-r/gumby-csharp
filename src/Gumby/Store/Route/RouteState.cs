using Gumby.Contract.Route;
using System.Collections.Generic;

namespace Gumby.Store.Route
{
    public class RouteState
    {
        public List<IRouteData> Routes { get; private set; }

        public RouteState(List<IRouteData> routes)
        {
            Routes = routes;
        }
    }
}
