using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.App.Shared
{
    public class GumbyDateTimeBase : ComponentBase
    {
        [Parameter] public DateTimeOffset Value { get; set; }

        protected string GetDisplayString()
        {
            IDateTimeHelper datetimeHelper = new EnglishDateTimeHelper();
            return datetimeHelper.GetFriendlyElapsedTime(this.Value);
        }

    }
}
