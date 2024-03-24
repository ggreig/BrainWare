namespace Api.Tests.Controllers
{
    using Models;

    public static class TestDataForOrder
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

        public static List<Order> Single { get; } = [order1];
        public static List<Order> Multi { get; } = [order1, order2];
    }
}