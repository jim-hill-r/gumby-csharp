using Blazor.Fluxor;
using Gumby.Climb.Route.Contract;
using System.Collections.Generic;

namespace Gumby.App.Climb.Route.Store
{
    public class RouteFeature : Feature<RouteState>
    {
        public override string GetName() => "Route";
        protected override RouteState GetInitialState() => new RouteState(new List<IRouteData>());
    }
}
