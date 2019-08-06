using System;
using System.Collections.Generic;
using System.Text;

namespace Gumby.Domain.Common.DateTime.English
{
    public class EnglishDateTimeHelper : IDateTimeHelper
    {
        public string GetFriendlyElapsedTime(DateTimeOffset datetime)
        {
            if (datetime == null)
            {
                return "";
            }

            DateTimeOffset now = DateTimeOffset.UtcNow;
            TimeSpan timespan = now - datetime;

            if (timespan.TotalDays > 14)
            {
                return datetime.ToLocalTime().DateTime.ToShortDateString();
            }
            else if (timespan.TotalDays > 7)
            {
                return $"last week";
            }
            else if (timespan.TotalDays > 2)
            {
                return $"{timespan.Days} days ago";
            }
            else if (timespan.TotalDays > 1)
            {
                return $"yesterday";
            }
            else if (timespan.TotalHours > 2)
            {
                return $"{timespan.Hours} hours ago";
            }
            else if (timespan.TotalHours > 1)
            {
                return $"{timespan.Hours} hour ago";
            }
            else if (timespan.TotalMinutes > 0)
            {
                return $"{timespan.Minutes} minutes ago";
            }
            else if (timespan.TotalSeconds > 0)
            {
                return $"{timespan.Seconds} seconds ago";
            }
            else
            {
                return "just now";
            }
        }
    }
}
