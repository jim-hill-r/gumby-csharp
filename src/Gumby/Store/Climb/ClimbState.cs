using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.Store.Climb
{
    public class ClimbState
    {
        public int NumClimbs { get; private set; }

        public ClimbState(int numClimbs)
        {
            NumClimbs = numClimbs;
        }
    }
}
