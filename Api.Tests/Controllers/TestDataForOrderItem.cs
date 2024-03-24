namespace Api.Tests.Controllers
{
    using Models;

    public static class TestDataForOrderItem
    {
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

        public static List<OrderProduct> Single { get; } = [order1Item1];
        public static List<OrderProduct> Multi { get; } = [order1Item1, order1Item2];
    }
}