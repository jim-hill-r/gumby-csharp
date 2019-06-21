using Gumby.Contract.Route;
using Gumby.Model.Route;
using System;

namespace Gumby.Services.Route
{
    public class NativeRouteService : IRouteService
    {
        public static int RouteCount = 0;
        public IRouteData GetNewRouteDefault()
        {
            RouteCount++;
            return new RouteData()
            {
                Id = Guid.NewGuid(),
                OriginationDate = DateTime.Now,
                RouteId = Guid.NewGuid(),
                RouteName = $"Route {RouteCount}"
            };
        }
    }
}
