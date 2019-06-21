using System;
using System.Collections.Generic;

namespace Gumby.Contract.Route
{
    public interface IProtectionService
    {
        IEnumerable<IProtectionData> GetProtections();
        IProtectionData GetProtection(Guid id);
    }
}
