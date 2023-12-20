using ExecutionAPI.Model;

namespace ExecutionAPI.Behaviors.OrderRetriever
{
    public class EquityOrderRetriever : IOrderRetriever
    {
        
        List<Order> IOrderRetriever.RetrieveOrder(OrderRequest orderRequest)
        {
            return new List<Order>() { new Order() { OrderId="First ", Type="Equity" } };
        }
    }
}
