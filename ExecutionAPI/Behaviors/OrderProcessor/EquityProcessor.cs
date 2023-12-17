using ExecutionAPI.Model;

namespace ExecutionAPI.Behaviors.OrderProcessor
{
    public class EquityProcessor : IProcessor
    {
        public void Process(OrderRequest Request)
        {
            Task.Delay(100).Wait();
            Request.OrderName = "EquityProcessor";
            Console.WriteLine("EquityProcessor");
        }
    }
}
