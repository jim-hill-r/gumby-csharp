using Blazor.Fluxor;
using Gumby.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.Store.Route
{
    public class RouteFeature : Feature<RouteState>
    {
        public override string GetName() => "route";
        protected override RouteState GetInitialState() => new RouteState(new List<IRoute>());
    }
}
