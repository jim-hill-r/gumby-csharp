using Confluent.Kafka;
using Gumby.Configuration;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Gumby.Event
{
    public class GumbyEventSubscriber<T> : IEventSubscriber<T>, IDisposable where T:IEvent
    {
        private readonly IConsumer<Ignore, string> _consumer;
        private readonly CancellationTokenSource _cancellationTokenSource;

        public GumbyEventSubscriber(IConfiguration configuration)
        {
            var groupName = "subscriberGroup";
            var consumerConfig = new ConsumerConfig
            { 
                GroupId = groupName,
                BootstrapServers = configuration.GumbyEventConfiguration.Hostname,
                AutoOffsetReset = AutoOffsetReset.Earliest

            };
            _consumer = new ConsumerBuilder<Ignore, string>(consumerConfig).Build();
            _consumer.Subscribe(nameof(T));
            _cancellationTokenSource = new CancellationTokenSource();
        }
        
        public async Task Consume()
        {
            try
            {
                var cr = _consumer.Consume(_cancellationTokenSource.Token);
                Console.WriteLine($"Consumed message '{cr.Value}' at: '{cr.TopicPartitionOffset}'.");
            }
            catch (ConsumeException e)
            {
                Console.WriteLine($"Error occured: {e.Error.Reason}");
            }
        }
        public void Dispose()
        {
            _consumer.Close();
            _consumer.Dispose();
        }
    }
}
