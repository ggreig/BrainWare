namespace Api.Infrastructure
{
    using Models;

    public class OrderService(IDatabase database) : IOrderService
    {
        public List<Order> GetOrdersForCompany(int companyId)
        {
            // Get the orders
            List<Order> orders = database.GetOrders(companyId);
            List<OrderProduct> orderProducts = database.GetOrderDetails(companyId);

            foreach (Order order in orders)
            {
                foreach (OrderProduct orderProduct in orderProducts
                             .Where(orderProduct => orderProduct.OrderId == order.OrderId))
                {
                    order.OrderProducts.Add(orderProduct);
                    order.OrderTotal += (orderProduct.Price * orderProduct.Quantity);
                }
            }

            return orders;
        }
    }
}