using Gumby.Contract.Route;
using Gumby.Model.Route;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gumby.Services.Route
{
    public class NativeProtectionService : IProtectionService
    {
        private IEnumerable<IProtectionData> _protectionDatas;
        public IEnumerable<IProtectionData> GetProtections()
        {
            if(_protectionDatas == null)
            {
                _protectionDatas = new List<IProtectionData>()
                {
                    new ProtectionData() { Id = Guid.NewGuid(), DisplayName = "No Protection / Boulder" },
                    new ProtectionData() { Id = Guid.NewGuid(), DisplayName = "Top Rope" },
                    new ProtectionData() { Id = Guid.NewGuid(), DisplayName = "Sport Lead"},
                    new ProtectionData() { Id = Guid.NewGuid(), DisplayName = "Trad Lead"},
                    new ProtectionData() { Id = Guid.NewGuid(), DisplayName = "Rope Solo"}
                };
            }
            return _protectionDatas;
        }

        public IProtectionData GetProtection(Guid id)
        {
            IEnumerable<IProtectionData> protectionDatas = GetProtections();
            var protectionData = protectionDatas.First(p => p.Id.Equals(id));
            if(protectionData == null)
            {
                throw new ArgumentException("Id provided is not valid.", "id");
            }
            return protectionData;
        }
    }
}
