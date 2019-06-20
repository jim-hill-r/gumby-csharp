using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Fluxor;
using Gumby.Contract;
using Gumby.Model.Climb;

namespace Gumby.Store.Climb
{
    public class AddClimbAction : IAction
    {
        public IClimb Climb { get; }

        public AddClimbAction(IClimb newClimb)
        {
            Climb = new ClimbMinimal()
            {
                Id = Guid.NewGuid(),
                OccurredAt = DateTimeOffset.UtcNow,
                RouteId = Guid.NewGuid(),
                RouteName = "New Climb!!!"
                
            };
            
        }
    }
}
