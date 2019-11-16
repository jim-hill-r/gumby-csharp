using Gumby.Event.Models;
using System.Threading.Tasks;

namespace Gumby.Event
{
    public interface IEventPublisher
    {
        Task Publish<T>(T evnt) where T : IEvent;
    }
}
