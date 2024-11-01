using MassTransit;
using MassTransitRabbitMQWebApi.Models;

namespace MassTransitRabbitMQWebApi.Consumers
{
    public class ExampleConsumer : IConsumer<ExampleMessage>
    {
        public Task Consume(ConsumeContext<ExampleMessage> context)
        {
            Console.WriteLine($"Received message: {context.Message.Text}");
            return Task.CompletedTask;
        }
    }
}
