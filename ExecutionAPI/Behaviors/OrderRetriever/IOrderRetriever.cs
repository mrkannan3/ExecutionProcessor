using ExecutionAPI.Model;

namespace ExecutionAPI.Behaviors.OrderRetriever
{
    public interface IOrderRetriever
    {
        List<Order> RetrieveOrder(OrderRequest orderRequest);
    }
}
