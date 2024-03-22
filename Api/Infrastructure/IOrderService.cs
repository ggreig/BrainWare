namespace Api.Infrastructure
{
    using Models;

    public interface IOrderService
    {
        List<Order> GetOrdersForCompany(int CompanyId);
    }
}