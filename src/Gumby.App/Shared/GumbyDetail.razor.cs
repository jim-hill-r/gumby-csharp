using Gumby.App.Climb.Journal.Models;
using Microsoft.AspNetCore.Components;

namespace Gumby.App.Shared
{
    public class GumbyDetailBase : ComponentBase
    {
        [Parameter] public Detail Value { get; set; }
    }
}
