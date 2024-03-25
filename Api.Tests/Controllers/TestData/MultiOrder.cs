namespace Api.Tests.Controllers.TestData
{
    using Models;

    public static class MultiOrder
    {
        private static readonly Order order1 = new()
        {
            CompanyName = "Test Company",
            Description = "Test Order",
            OrderId = 1,
            OrderProducts = [],
            OrderTotal = 0
        };

        private static readonly Order order2 = new()
        {
            CompanyName = "Test Company",
            Description = "Test Order 2",
            OrderId = 2,
            OrderProducts = [],
            OrderTotal = 0
        };

        public static List<Order> GetOrders() => [order1, order2];
    }
}