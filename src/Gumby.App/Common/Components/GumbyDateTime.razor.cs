using Gumby.Domain.Common.DateTime;
using Gumby.Domain.Common.DateTime.English;
using Microsoft.AspNetCore.Components;
using System;

namespace Gumby.App.Common.Components
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
