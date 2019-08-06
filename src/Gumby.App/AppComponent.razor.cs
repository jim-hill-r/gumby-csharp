using MatBlazor;
using Microsoft.AspNetCore.Components;

namespace Gumby.App
{
    public class AppComponentBase : ComponentBase
    {
        protected MatTheme _theme = new MatTheme()
        {
            Primary = MatThemeColors.Green._600.Value,
            Secondary = MatThemeColors.Indigo._500.Value
        };
    }
}
