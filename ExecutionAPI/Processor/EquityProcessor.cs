using ExecutionAPI.Model;

namespace ExecutionAPI.Processor
{
    public class EquityProcessor : IExecutionProcessor
    {
        void IExecutionProcessor.Process(OrderRequest Request)
        {
            Request.OrderName = "EquityProcessor";
            Console.WriteLine("EquityProcessor");
        }
    }
}
