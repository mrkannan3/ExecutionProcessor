using ExecutionAPI.Model;

namespace ExecutionAPI.Processor
{
    public interface IExecutionProcessor
    {
        void Process(OrderRequest Request);
    }
}
