using Confluent.Kafka;
using Gumby.Configuration;
using Gumby.Event.Models;
using System;
using System.Threading.Tasks;

namespace Gumby.Event
{
    public class GumbyEventPublisher : IEventPublisher, IDisposable
    {
        private readonly IProducer<Null, string> _producer;
        public GumbyEventPublisher(IConfiguration configuration)
        {
            var producerConfig = new ProducerConfig { BootstrapServers = configuration.GumbyEventConfiguration.Hostname };
            _producer = new ProducerBuilder<Null, string>(producerConfig).Build();
        }
        
        public async Task Publish<T>(T evnt) where T:IEvent
        {
            try
            {
                var dr = await _producer.ProduceAsync(nameof(evnt), new Message<Null, string> { Value = evnt.Message });
                Console.WriteLine($"Delivered '{dr.Value}' to '{dr.TopicPartitionOffset}'");
            }
            catch (ProduceException<Null, string> e)
            {
                Console.WriteLine($"Delivery failed: {e.Error.Reason}");
            }
        }
        public void Dispose()
        {
            _producer.Dispose();
        }
    }
}
