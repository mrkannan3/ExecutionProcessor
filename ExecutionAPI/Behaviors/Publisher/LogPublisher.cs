using ExecutionAPI.Model;

namespace ExecutionAPI.Behaviors.Publisher
{
    public class LogPublisher : IPublisher
    {
        public void Publish(OrderRequest orderRequest)
        {
            orderRequest.Type += "LogPublisher";
            Console.WriteLine("LogPublisher");
        }
    }
}
