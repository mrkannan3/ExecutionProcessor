using ExecutionAPI.Model;

namespace ExecutionAPI.Processor
{
    public class MFProcessor : IExecutionProcessor
    {
        void IExecutionProcessor.Process(OrderRequest Request)
        {
            Request.OrderName = "MFProcessor";
            Console.WriteLine("MFProcessor");
        }
    }
}
