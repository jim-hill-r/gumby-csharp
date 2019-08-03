using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.App.Shared
{
    public class GumbyTextBoxBase : ComponentBase
    {
        [Parameter]
        public string Value { get; set; } = "";
        [Parameter]
        public bool ReadOnly { get; set; } = true;
    }
}
