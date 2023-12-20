using ExecutionAPI.Model;

namespace ExecutionAPI.Behaviors.Publisher
{
    public class LogPublisher : IPublisher
    {
        public void Publish(List<Order> orders)
        {
            orders.FirstOrDefault().OrderId += "LogPublisher";
            Console.WriteLine("EventPublisher");
        }
    }
}
