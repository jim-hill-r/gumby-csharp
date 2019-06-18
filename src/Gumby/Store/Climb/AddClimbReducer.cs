using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Fluxor;

namespace Gumby.Store.Climb
{
    public class AddClimbReducer : Reducer<ClimbState, AddClimbAction>
    {
        public override ClimbState Reduce(ClimbState state, AddClimbAction action)
        {
            return new ClimbState(state.NumClimbs + 1);
        }
    }
}
