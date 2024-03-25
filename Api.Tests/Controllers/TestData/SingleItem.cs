namespace Api.Tests.Controllers.TestData
{
    using Models;

    public static class SingleItem
    {
        private static readonly OrderProduct orderItem = new()
        {
            OrderId = 1,
            ProductId = 1,
            Product = new Product { Name = "Test Product 1", Price = 10 },
            Quantity = 1,
            Price = 10
        };

        public static List<OrderProduct> GetItem() => [orderItem];
    }
}