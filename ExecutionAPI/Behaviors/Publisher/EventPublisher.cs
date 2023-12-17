using ExecutionAPI.Model;

namespace ExecutionAPI.Behaviors.Publisher
{
    public class EventPublisher : IPublisher
    {
        public void Publish(OrderRequest orderRequest)
        {
            orderRequest.Type += "EventPublisher";
            Console.WriteLine("EventPublisher");
        }
    }
}
