using System.Threading.Tasks;

namespace Gumby.Event
{
    public interface IEventSubscriber<T>
    {
        Task Consume();
    }
}
