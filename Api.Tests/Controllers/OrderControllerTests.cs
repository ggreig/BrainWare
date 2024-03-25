namespace Api.Tests.Controllers
{
    using Api.Controllers;
    using FluentAssertions;
    using FluentAssertions.Execution;
    using Infrastructure;
    using Models;
    using NSubstitute;
    using TestData;

    [TestFixture]
    [TestOf(typeof(OrderController))]
    public static class OrderControllerTests
    {
        [Test]
        public static void GetOrders_WithSingleItem_ShouldContainExpectedItemOnly()
        {
            // Arrange
            var database = Substitute.For<IDatabase>();
            database.GetOrders(1).Returns(SingleOrder.GetOrder());
            database.GetOrderDetails(1).Returns(SingleItem.GetItem());

            var orderService = new OrderService(database);
            var orderController = new OrderController(orderService);

            // Act
            List<Order> result = orderController.GetOrders(1).ToList();

            // Assert
            using (new AssertionScope())
            {
                result.Should().HaveCount(1, "because 1 order has been placed");
                result[0].OrderProducts.Should().HaveCount(1, "because 1 item was included");
                result[0].OrderProducts[0].Product.Name.Should().Be("Test Product 1");
            }
        }

        [Test]
        public static void GetOrders_WithMultiOrders_ShouldContainExpectedItems()
        {
            // Arrange
            var database = Substitute.For<IDatabase>();
            database.GetOrders(1).Returns(MultiOrder.GetOrders());
            database.GetOrderDetails(1).Returns(MultiItem.GetItems());
            
            var orderService = new OrderService(database);
            var orderController = new OrderController(orderService);

            // Act
            List<Order> result = orderController.GetOrders(1).ToList();

            // Assert
            using (new AssertionScope())
            {
                result.Should().HaveCount(2, "because 2 orders have been placed");
                result[0].OrderProducts.Should().HaveCount(2, "because 2 items were included");
                result[0].OrderProducts[0].Product.Name.Should().Be("Test Product 1");
                result[0].OrderProducts[1].Product.Name.Should().Be("Test Product 2");
                result[1].OrderProducts.Should().HaveCount(1, "because 1 items were included");
                result[1].OrderProducts[0].Product.Name.Should().Be("Test Product 3");
            }
        }
    }
}