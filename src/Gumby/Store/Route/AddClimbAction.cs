using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Fluxor;
using Gumby.Contract;
using Gumby.Model.Route;

namespace Gumby.Store.Route
{
    public class AddRouteAction : IAction
    {
        public IRoute Route { get; }

        public AddRouteAction(IRoute newRoute)
        {
            Route = new RouteMinimal()
            {
                Id = Guid.NewGuid(),
                OriginatedAt = DateTime.UtcNow,
                RouteId = Guid.NewGuid(),
                RouteName = "New Route!!!"
                
            };

        }
    }
}
