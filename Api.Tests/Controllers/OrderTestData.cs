namespace Api.Tests.Controllers
{
    using Models;

    public static class OrderTestData
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

        public static readonly List<Order> singleOrder = [order1];
        private static readonly List<Order> multiOrder = [order2];

        private static readonly OrderProduct order1Item1 = new()
        {
            OrderId = 1,
            ProductId = 1,
            Product = new Product { Name = "Test Product 1", Price = 10 },
            Quantity = 1,
            Price = 10
        };

        private static readonly OrderProduct order1Item2 = new()
        {
            OrderId = 1,
            ProductId = 2,
            Product = new Product { Name = "Test Product 2", Price = 20 },
            Quantity = 1,
            Price = 20
        };

        public static readonly List<OrderProduct> singleOrderItem = [order1Item1];
        private static readonly List<OrderProduct> multiOrderItem = [order1Item1, order1Item2];
    }
}