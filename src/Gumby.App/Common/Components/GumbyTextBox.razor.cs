using Microsoft.AspNetCore.Components;

namespace Gumby.App.Common.Components
{
    public class GumbyTextBoxBase : ComponentBase
    {
        [Parameter] public string Value { get; set; } = "";
        [Parameter] public bool ReadOnly { get; set; } = true;
    }
}
