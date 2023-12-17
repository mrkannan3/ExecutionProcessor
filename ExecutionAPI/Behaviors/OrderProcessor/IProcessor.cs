using ExecutionAPI.Model;

namespace ExecutionAPI.Behaviors.OrderProcessor
{
    public interface IProcessor
    {
        public void Process(OrderRequest orderRequest);
    }
}
