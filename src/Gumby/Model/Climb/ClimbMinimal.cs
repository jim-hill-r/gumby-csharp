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
        
        public DateTime OccurredAt { get; set; }
        
        public TimeZoneInfo OccuredAtTimezone { get; set; }

        public Guid RouteId { get; set; }

        public string RouteName { get; set; }
    }
}
