using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.App
{
    public class AppBase : ComponentBase
    {
        protected MatTheme _theme = new MatTheme()
        {
            Primary = MatThemeColors.Green._600.Value,
            Secondary = MatThemeColors.Indigo._500.Value
        };
    }
}
