using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gumby.Climb.Route.Contract
{
    public enum ProtectionType
    {
        NONE,
        BOULDER,
        TOPROPE,
        SPORTFOLLOW,
        TRADFOLLOW,
        SPORTLEAD,
        TRADLEAD,
        ROPESOLO,
        FREESOLO
    }

    public static class ProtectionTypeHelper
    {
        public static IList<ProtectionType> GetAll()
        {
            return Enum.GetValues(typeof(ProtectionType)).Cast<ProtectionType>().Where(pt => !pt.Equals(ProtectionType.NONE)).ToList();
        }

        public static string GetDisplayName(this ProtectionType protectionType)
        {
            switch (protectionType)
            {
                case ProtectionType.NONE:
                    return "Missing";
                case ProtectionType.BOULDER:
                    return "Bouldering";
                case ProtectionType.TOPROPE:
                    return "Top Rope";
                case ProtectionType.SPORTFOLLOW:
                    return "Follow (Sport)";
                case ProtectionType.TRADFOLLOW:
                    return "Follow (Trad)";
                case ProtectionType.SPORTLEAD:
                    return "Lead (Sport)";
                case ProtectionType.TRADLEAD:
                    return "Lead (Trad)";
                case ProtectionType.ROPESOLO:
                    return "Solo (Rope)";
                case ProtectionType.FREESOLO:
                    return "Free Solo";
                default:
                    return "Missing";
            }
        }
    }
}
