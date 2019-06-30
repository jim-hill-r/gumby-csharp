using System;
using Blazor.Fluxor;
using Gumby.Climb.Route.Contract;

namespace Gumby.App.Climb.Route.Store
{
    public class AddRouteReducer : Reducer<RouteState, AddRouteAction>
    {
        public override RouteState Reduce(RouteState state, AddRouteAction action)
        {
            int routeCount = state.Routes.Count + 1;
            state.Routes.Insert(0, new RouteData()
            {
                Id = Guid.NewGuid(),
                OriginationDate = DateTime.UtcNow,
                RouteName = "Route " + routeCount
            });

            return state;
        }

        private class RouteData : IRouteData
        {
            public Guid Id { get; set; }

            public DateTime OriginationDate { get; set; }

            public string RouteName { get; set; }
        }

    }
}
