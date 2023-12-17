using ExecutionAPI.Model;
using ExecutionAPI.Processor;

namespace ExecutionAPI.Behaviors.OrderProcessor
{
    public class MFProcessor : IProcessor
    {
        public void Process(OrderRequest Request)
        {
            Task.Delay(100).Wait();
            Request.OrderName = "MFProcessor";
            Console.WriteLine("MFProcessor");
        }
    }
}
