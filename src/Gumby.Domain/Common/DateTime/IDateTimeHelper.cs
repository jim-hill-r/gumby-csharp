using System;
using System.Collections.Generic;
using System.Text;

namespace Gumby.Domain.Common.DateTime
{
    public interface IDateTimeHelper
    {
        string GetFriendlyElapsedTime(DateTimeOffset datetime);
    }
}
