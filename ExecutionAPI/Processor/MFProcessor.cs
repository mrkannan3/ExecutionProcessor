using ExecutionAPI.Model;

namespace ExecutionAPI.Processor
{
    public class MFProcessor : IExecutionProcessor
    {
        void IExecutionProcessor.Process(OrderRequest Request)
        {
            Task.Delay(100).Wait();
            Request.OrderName = "MFProcessor";
            Console.WriteLine("MFProcessor");
        }
    }
}
