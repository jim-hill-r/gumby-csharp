using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Fluxor;

namespace Gumby.Store.Route
{
    public class AddRouteReducer : Reducer<RouteState, AddRouteAction>
    {
        public override RouteState Reduce(RouteState state, AddRouteAction action)
        {
            state.Routes.Insert(0,action.Route);
            return state;
        }
    }
}
