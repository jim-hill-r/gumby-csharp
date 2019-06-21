using Gumby.Contract.Route;
using System;

namespace Gumby.Model.Route
{
    public class ProtectionData : IProtectionData
    {
        public Guid Id { get; set; }

        public string DisplayName { get; set; }
    }
}
