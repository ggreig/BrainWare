namespace Api.Infrastructure
{
    using Models;

    internal interface IDatabase
    {
        List<Order> GetOrders(int companyId);
        List<OrderProduct> GetOrderDetails(int companyId);
    }
}