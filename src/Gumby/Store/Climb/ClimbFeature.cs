﻿using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.Store.Climb
{
    public class ClimbFeature : Feature<ClimbState>
    {
        public override string GetName() => "Climb";
        protected override ClimbState GetInitialState() => new ClimbState(0);
    }
}
