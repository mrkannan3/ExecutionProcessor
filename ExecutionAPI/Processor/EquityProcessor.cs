using ExecutionAPI.Model;

namespace ExecutionAPI.Processor
{
    public class EquityProcessor : IExecutionProcessor
    {
        void IExecutionProcessor.Process(OrderRequest Request)
        {
            Task.Delay(100).Wait();
            Request.OrderName = "EquityProcessor";
            Console.WriteLine("EquityProcessor");
        }
    }
}
