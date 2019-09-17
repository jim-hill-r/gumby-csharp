using Gumby.App.Journal.Models;
using Microsoft.AspNetCore.Components;

namespace Gumby.App.Journal.Components
{
    public class GumbyDetailBase : ComponentBase
    {
        [Parameter] public Detail Value { get; set; }
    }
}
