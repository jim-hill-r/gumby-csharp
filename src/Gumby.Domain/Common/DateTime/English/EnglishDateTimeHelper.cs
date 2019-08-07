using System;

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

            if (timespan.Days > 14)
            {
                return datetime.ToLocalTime().DateTime.ToShortDateString();
            }
            else if (timespan.Days > 7)
            {
                return $"last week";
            }
            else if (timespan.Days > 2)
            {
                return $"{timespan.Days} days ago";
            }
            else if (timespan.Days > 1)
            {
                return $"yesterday";
            }
            else if (timespan.Hours > 2)
            {
                return $"{timespan.Hours} hours ago";
            }
            else if (timespan.Hours > 1)
            {
                return $"{timespan.Hours} hour ago";
            }
            else if (timespan.Minutes > 0)
            {
                return $"{timespan.Minutes} minutes ago";
            }
            else if (timespan.Seconds > 0)
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
