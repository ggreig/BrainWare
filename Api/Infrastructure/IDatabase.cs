namespace Api.Infrastructure
{
    using Models;

    public interface IDatabase
    {
        List<Order> GetOrders(int companyId);
        List<OrderProduct> GetOrderDetails(int companyId);
    }
}