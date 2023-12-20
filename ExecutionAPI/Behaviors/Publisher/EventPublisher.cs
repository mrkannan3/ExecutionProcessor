using ExecutionAPI.Model;

namespace ExecutionAPI.Behaviors.Publisher
{
    public class EventPublisher : IPublisher
    {
        public void Publish(List<Order> orders)
        {
            orders.FirstOrDefault().OrderId += "EventPublisher";
            Console.WriteLine("EventPublisher");
        }
    }
}
