namespace Api.Tests.Controllers.TestData
{
    using Models;

    public static class SingleOrder
    {
        private static readonly Order order = new()
        {
            CompanyName = "Test Company",
            Description = "Test Order",
            OrderId = 1,
            OrderProducts = [],
            OrderTotal = 0
        };

        public static List<Order> GetOrder() => [order];
    }
}