using Gumby.Contract.Route;
using System;

namespace Gumby.Model.Route
{
    public class RouteData : IRouteData
    {
        public Guid Id { get; set; }
        
        public DateTime OriginationDate { get; set; }
        
        public Guid RouteId { get; set; }

        public string RouteName { get; set; }
    }
}
