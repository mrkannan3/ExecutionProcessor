using ExecutionAPI.Behaviors.OrderProcessor;
using ExecutionAPI.Behaviors.Publisher;
using ExecutionAPI.Model;
using System.Diagnostics;

namespace ExecutionAPI.Processor
{
    public class ExecutionProcessor
    {
        private readonly Factory _factory;
        public ExecutionProcessor(Factory factory)
        {
            _factory = factory;
        }
        public void ProcessOrder(OrderRequest request)
        {
            var publisher = _factory.GetRequiredService<IPublisher>(request.PublishType);
            var processor = _factory.GetRequiredService<IProcessor>(request.Type);

            processor.Process(request);
            publisher.Publish(request);
        }
    }
}
