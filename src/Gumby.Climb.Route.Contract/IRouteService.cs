using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gumby.Climb.Route.Contract
{
    public interface IRouteService
    {
        Task<IEnumerable<IRouteData>> GetRoutesAsync(int count);
        Task<IRouteData> GetRouteAsync(Guid id);
        Task<Guid> CreateRouteAsync(IRouteData route);
        Task<Guid> UpdateRouteAsync(IRouteData route);
        Task<Guid> DeleteRouteAsync(Guid id);
    }
}
