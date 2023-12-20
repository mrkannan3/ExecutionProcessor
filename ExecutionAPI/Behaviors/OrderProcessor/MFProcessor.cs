using ExecutionAPI.Model;
using ExecutionAPI.Processor;

namespace ExecutionAPI.Behaviors.OrderProcessor
{
    public class MFProcessor : IProcessor
    {
        public void Process(List<Order> orders)
        {
            Task.Delay(100).Wait();
            orders.FirstOrDefault().OrderId = "MFProcessor";
            Console.WriteLine("MFProcessor");
        }
    }
}
