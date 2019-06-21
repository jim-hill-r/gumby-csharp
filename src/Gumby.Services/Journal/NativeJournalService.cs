using Gumby.Contract.Journal;
using Gumby.Contract.Route;
using Gumby.Model.Journal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gumby.Services.Route
{
    public class NativeJournalService : IJournalService
    {
        private readonly string NEW_CLIMB_TITLE = "Climb";
        private readonly string MOONLIGHT_TITLE = "Moonlit";
        private readonly string MORNING_TITLE = "Morning";
        private readonly string AFTERNOON_TITLE = "Afternoon";
        private readonly string EVENING_TITLE = "Evening";
        private readonly string NIGHT_TITLE = "Night";

        private IProtectionService _protectionService;
        public NativeJournalService(IProtectionService protectionService)
        {
            _protectionService = protectionService;
        }

        public IJournalData GetNewJournalDefault()
        {
            List<IProtectionData> protectionDatas = _protectionService.GetProtections().ToList();
            return new JournalData()
            {
                Id = Guid.NewGuid(),
                Name = GetNewNameDefault(),
                OccurredAt = DateTimeOffset.UtcNow,
                RouteId = Guid.NewGuid(),
                RouteName = "Searching for route ....",
                ProtectionId = protectionDatas.FirstOrDefault().Id,
                ProtectionName = protectionDatas.FirstOrDefault().DisplayName
            };
        }

        private string GetNewNameDefault()
        {
            string climbName = "";
            var currentTime = DateTime.Now;
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
