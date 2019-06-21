using Blazor.Fluxor;
using Gumby.Contract.Route;
using System.Collections.Generic;

namespace Gumby.Store.Route
{
    public class RouteFeature : Feature<RouteState>
    {
        public override string GetName() => "Route";
        protected override RouteState GetInitialState() => new RouteState(new List<IRouteData>());
    }
}
