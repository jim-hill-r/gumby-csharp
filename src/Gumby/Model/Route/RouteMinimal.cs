using Gumby.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.Model.Route
{
    public class RouteMinimal : IRoute
    {
        public Guid Id { get; set; }
        
        public DateTime OriginationDate { get; set; }
        
        public Guid RouteId { get; set; }

        public string RouteName { get; set; }
    }
}
