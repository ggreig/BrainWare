namespace Api.Tests.Controllers.TestData
{
    using Models;

    public static class MultiItem
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

        private static readonly OrderProduct order2Item1 = new()
        {
            OrderId = 2,
            ProductId = 3,
            Product = new Product { Name = "Test Product 3", Price = 30 },
            Quantity = 1,
            Price = 30
        };

        public static List<OrderProduct> GetItems() => [order1Item1, order1Item2, order2Item1];
    }
}