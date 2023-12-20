using ExecutionAPI.Model;

namespace ExecutionAPI.Behaviors.OrderRetriever
{
    public class MFOrderRetriever : IOrderRetriever
    {
        List<Order> IOrderRetriever.RetrieveOrder(OrderRequest orderRequest)
        {
            return new List<Order>() { new Order() { OrderId = "First ", Type = "MF" } };
        }
    }
}
