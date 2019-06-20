using Gumby.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.Model.Climb
{
    public class ClimbMinimal : IClimb
    {
        public Guid Id { get; set; }
        
        public DateTimeOffset OccurredAt { get; set; }

        public Guid RouteId { get; set; }

        public string RouteName { get; set; }
    }
}
