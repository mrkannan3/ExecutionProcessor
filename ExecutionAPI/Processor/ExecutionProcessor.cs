using ExecutionAPI.Behaviors.OrderProcessor;
using ExecutionAPI.Behaviors.OrderRetriever;
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
        public List<Order> ProcessOrder(OrderRequest request)
        {
            var retriever = _factory.GetRequiredService<IOrderRetriever>(request.Type);
            var publisher = _factory.GetRequiredService<IPublisher>(request.PublishType);
            var processor = _factory.GetRequiredService<IProcessor>(request.Type);

            var orders = retriever.RetrieveOrder(request);
            processor.Process(orders);
            publisher.Publish(orders);
            return orders;
        }
    }
}
