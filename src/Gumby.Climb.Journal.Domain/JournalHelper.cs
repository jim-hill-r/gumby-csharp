using System;

namespace Gumby.Climb.Journal.Domain
{
    public static class JournalHelper
    {
        private static readonly string NEW_CLIMB_TITLE = "Climb";
        private static readonly string MOONLIGHT_TITLE = "Moonlit";
        private static readonly string MORNING_TITLE = "Morning";
        private static readonly string AFTERNOON_TITLE = "Afternoon";
        private static readonly string EVENING_TITLE = "Evening";
        private static readonly string NIGHT_TITLE = "Night";

        public static string GetNewName(DateTime currentTime)
        {
            string climbName = "";
            if (currentTime.Hour < 5)
            {
                climbName = $"{MOONLIGHT_TITLE} {NEW_CLIMB_TITLE}";
            }
            else if (currentTime.Hour < 12)
            {
                climbName = $"{MORNING_TITLE} {NEW_CLIMB_TITLE}";
            }
            else if (currentTime.Hour < 17)
            {
                climbName = $"{AFTERNOON_TITLE} {NEW_CLIMB_TITLE}";
            }
            else if (currentTime.Hour < 21)
            {
                climbName = $"{EVENING_TITLE} {NEW_CLIMB_TITLE}";
            }
            else
            {
                climbName = $"{NIGHT_TITLE} {NEW_CLIMB_TITLE}";
            }
            return climbName;
        }

    }
}
