using Gumby.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.Store.Climb
{
    public class ClimbState
    {
        public List<IClimb> Climbs { get; private set; }

        public ClimbState(List<IClimb> climbs)
        {
            Climbs = climbs;
        }
    }
}
