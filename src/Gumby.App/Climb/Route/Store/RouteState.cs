using Gumby.Climb.Route.Contract;
using System.Collections.Generic;

namespace Gumby.App.Climb.Route.Store
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
