using ExecutionAPI.Model;

namespace ExecutionAPI.Behaviors.OrderProcessor
{
    public class EquityProcessor : IProcessor
    {
        public void Process(List<Order> orders)
        {
            Task.Delay(100).Wait();
            orders.FirstOrDefault().OrderId = "EquityProcessor";
            Console.WriteLine("EquityProcessor");
        }
    }
}
