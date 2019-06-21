using Blazor.Fluxor;
using Gumby.Contract.Route;

namespace Gumby.Store.Route
{
    public class AddRouteAction : IAction
    {
        public IRouteData Route { get; }

        public AddRouteAction(IRouteData newRoute)
        {
            Route = newRoute;

        }
    }
}
